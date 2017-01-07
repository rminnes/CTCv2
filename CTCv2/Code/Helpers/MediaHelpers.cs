using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace CTCv2.Code.Helpers
{
    public static class MediaHelpers
    {

        public static string GetMediaURL(int mediaID)
        {
            var mediaFile = ApplicationContext.Current.Services.MediaService.GetById(mediaID);

            var url = mediaFile.GetValue("umbracoFile").ToString().Split('\'')[1];

            return url;
        }

        public static string GetMediaURL(string mediaID)
        {

            if (!string.IsNullOrEmpty(mediaID))
            {
                int intMediaID = 0;
                int.TryParse(mediaID, out intMediaID);
                return GetMediaURL(intMediaID);
            }
            else
                return "";
        }

    }
}