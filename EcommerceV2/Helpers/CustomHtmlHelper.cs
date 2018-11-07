using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceV2.Helpers
{
    public static class CustomHtmlHelper
    {
        public static HtmlString ProductIndex(List<Models.Product> products)
        {
            string finalString = "";
            foreach (Models.Product p in products)
            {
                finalString += String.Format(
                    "<div class='col-sm-6 col-md-4'>" +
                    "<div class='thumbnail'>" +
                    "<img src='{0}' alt='Example Picture' />" +
                    "<div class='caption'>" +
                    "<h3>{1}</h3>" +
                    "</div>" +
                    "<p>{2}</p>" +
                    "<a class='btn btn-primary' href='/Product/Details/{3}' role='button'>View Details</a>" +
                    "</div>" +
                    "</div>", p.ImageLink, p.Name, p.Description, p.Id);
            }

            return new HtmlString(finalString);
        }
    }
}