﻿namespace ImageGalleryManagement.Application.Contract.Slider
{
    public class SliderViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}