﻿using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;

namespace TravelingApp481.ViewModels
{
    public class TabPageCViewModel : BindableBase, IActiveAware
    {

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public event EventHandler IsActiveChanged;
        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                SetProperty(ref _isActive, value);
                IsActiveChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public TabPageCViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TabPageCViewModel)}:  ctor");
            Title = "Hotels";
            IsActiveChanged += OnIsActiveChanged;
        }

        private void OnIsActiveChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnIsActiveChanged)}: {IsActive}");
        }
    }
}

