using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    

    public class VideosController : ApiController
    {
        private readonly VideoDb db;

        public VideosController()
        {
            db = new VideoDb();
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/video
        public IEnumerable<Video> GetAllVideos()
        {
            return db.Videos;
        }

        // GET api/video/5
        public Video GetVideo(int id)
        {
            var video = db.Videos.Find(id);

            if (video == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return video;
        }

        // POST api/video
        public Video Post(Video video)
        {
            return video;
        }

        // PUT api/video/5
        public HttpResponseMessage Put(int id, Video video)
        {
            if (ModelState.IsValid && id == video.Id)
            {
                db.Entry(video).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, video);
            }
            
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        // DELETE api/video/5
        public void Delete(int id)
        {
        }
    }
}
