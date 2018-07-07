using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ContactApp.Models;

namespace ContactApp.Controllers
{
    public class ContactController : ApiController
    {
        private ContactInfoEntities db = new ContactInfoEntities();

        // GET: api/Contact
        public IQueryable<ContactDetail> GetContactDetails()
        {
            return db.ContactDetails;
        }

        // GET: api/Contact/5
        [ResponseType(typeof(ContactDetail))]
        public IHttpActionResult GetContactDetail(int id)
        {
            ContactDetail contactDetail = db.ContactDetails.Find(id);
            if (contactDetail == null)
            {
                return NotFound();
            }

            return Ok(contactDetail);
        }

        // PUT: api/Contact/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContactDetail(int id, ContactDetail contactDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contactDetail.ContactId)
            {
                return BadRequest();
            }

            db.Entry(contactDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Contact
        [ResponseType(typeof(ContactDetail))]
        public IHttpActionResult PostContactDetail(ContactDetail contactDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ContactDetails.Add(contactDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contactDetail.ContactId }, contactDetail);
        }

        // DELETE: api/Contact/5
        [ResponseType(typeof(ContactDetail))]
        public IHttpActionResult DeleteContactDetail(int id)
        {
            ContactDetail contactDetail = db.ContactDetails.Find(id);
            if (contactDetail == null)
            {
                return NotFound();
            }

            db.ContactDetails.Remove(contactDetail);
            db.SaveChanges();

            return Ok(contactDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactDetailExists(int id)
        {
            return db.ContactDetails.Count(e => e.ContactId == id) > 0;
        }
    }
}