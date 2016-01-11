using Schnap.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Schnap.Client.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks (this HtmlHelper html, PagingInfo paging_info, Func<int,string> page_url)
        {
            StringBuilder result = new StringBuilder();

            for (int i=1; i<=paging_info.total_pages; i++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href", page_url(i));
                tag.InnerHtml = i.ToString();
                if (i == paging_info.current_page)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}