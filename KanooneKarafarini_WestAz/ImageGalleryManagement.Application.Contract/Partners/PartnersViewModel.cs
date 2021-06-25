﻿using System.Security.Principal;

namespace ImageGalleryManagement.Application.Contract.Partners
{
    public class PartnersViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}
