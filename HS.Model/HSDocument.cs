using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Model
{
	/// <summary>
	/// HSDocument is a reference to a document within the website.
	/// Prefixed with HS to overcome possible issues with other Document classes
	/// </summary>
	public class HSDocument
	{
		/// <summary>
		/// Unique Identifier of the Document
		/// </summary>
		[Key]
		public int DocumentId { get; set; }

		/// <summary>
		/// Server based path of the document, it's location mapped to the web server.
		/// </summary>
		[StringLength(1024)]
		public string DocumentPath { get; set; }

		public string Title { get; set; }

		public Company Company { get; set; }

		public DateTime EntryDate { get; set; }

		public DateTime EndDate { get; set; }

		public virtual ICollection<Term> Terms { get; set; }

	}
}
