﻿using CTCv2.Code.Helpers;
using Umbraco.Core.Models;

namespace CTCv2.Models.ViewModels.Himu
{
    public class BlogPanelVM 
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string FullText { get; set; }
        public string Image { get;set;}
        public int Order { get; set; }

        public BlogPanelVM(IPublishedContent content)
        { 
            Id = content.Id;
            Title = content.GetProperty("title").DataValue.ToString();
            Text = content.GetProperty("text").DataValue.ToString();
            FullText = content.GetProperty("fullText").DataValue.ToString();
            Image = MediaHelpers.GetMediaURL(content.GetProperty("blogImage").DataValue.ToString());    
            Order = content.SortOrder;
        }


    }
}
