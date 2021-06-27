using System.Collections.Generic;
using System.Linq;
using _01_Query.Contract.Partners;
using ImageGalleryManagement.Infrastructure.EFCore;

namespace _01_Query.Query
{
public class PartnerQuery : IPartnerQuery
{
    private readonly ImageGalleryContext _context;

    public PartnerQuery(ImageGalleryContext context)
    {
        _context = context;
    }

    public List<PartnersQueryModel> GetPartners()
        {
            return _context.Partners
                .Where(x => x.IsRemoved == false)
                .Select(x => new PartnersQueryModel
                {
                    Name = x.Name,
                    Link = x.Link,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    

                }).ToList();
        }
    }
}
