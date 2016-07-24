﻿using System;
using System.Net;

namespace URLFetchers.Library
{
    public class URLFetcher : WebClient
    {
        public URLFetcher()
        {
            Encoding = System.Text.Encoding.UTF8;
        }

        /**
         * @see http://stackoverflow.com/questions/1789627/how-to-change-the-timeout-on-a-net-webclient-object
         */
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 20 * 60 * 1000;
            return w;
        }

        /**
         * @see http://stackoverflow.com/questions/1048199/easiest-way-to-read-from-a-url-into-a-string-in-net
         */
        public string fetch(string url)
        {
            if(null == url)
            {
                throw new System.ArgumentException("URL Parameter cannot be null", "original");
            }

            string web_contents = "";
            //WebClient client = new WebClient();
            //client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                //web_contents = client.DownloadString(url);
                web_contents = DownloadString(url);
            }
            catch(Exception)
            {

            }

            return web_contents;
        }

    }
}