using Microsoft.AspNetCore.Http;

namespace BatuTravelProje.Areas.Admin.Models
{
    public class GuideEditViewModel
    {
        public string guidename { get; set; }
        public string guidedescrition { get; set; }
        public IFormFile guideimage { get; set; }
        public string guideTwitterUrl { get; set; }
        public string guideInstagramUrl { get; set; }
    }
}
