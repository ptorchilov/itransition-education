﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    public class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
    }

    public class VideosController : ApiController
    {
        // GET api/video
        public IEnumerable<string> GetAllVideos()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/video/5
        public string Get(int id)
        {
            return "value " + id.ToString();
        }

        // POST api/video
        public Video Post(Video video)
        {
            return video;
        }

        // PUT api/video/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/video/5
        public void Delete(int id)
        {
        }
    }
}
