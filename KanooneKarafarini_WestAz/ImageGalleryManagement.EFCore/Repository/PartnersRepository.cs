using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ImageGalleryManagement.Application.Contract.Partners;
using ImageGalleryManagement.Domain.Partners;
using ImageGalleryManagement.Infrastructure.EFCore;

namespace ImageGalleryManagement.EFCore.Repository
{
    public class PartnersRepository : RepositoryBase<long,Partners> , IPartnersRepository
    {
        private readonly ImageGalleryContext _context;
        public PartnersRepository(ImageGalleryContext context) : base(context)
        {
            _context = context;
        }

        public EditPartners GetDetails(long id)
        {
            return _context.Partners.Select(x => new EditPartners
            {
                Id = x.Id,
                Name = x.Name,
                //Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,
                Link = x.Link
                

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<PartnersViewModel> GetList()
        {
            return _context.Partners.Select(x => new PartnersViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()


            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
