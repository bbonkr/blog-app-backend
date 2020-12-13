using System;
using System.Collections.Generic;

namespace MangoBlog.Entities
{
    public class Post : EntityBase
    {
        public string Title { get; set; }

        /// <summary>
        /// Wrtie markdown
        /// </summary>
        public string Markdown { get; set; }

        /// <summary>
        /// Read html
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Search text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        public virtual User Author { get; set; }

        public PostType Type { get; set; }

        /// <summary>
        /// Public post
        /// </summary>
        public bool IsPublic { get; set; } = true;

        /// <summary>
        /// Published
        /// </summary>
        public bool IsPublished { get; set; } = false;

        public DateTimeOffset? PublishedAt { get; set; }

        public IList<PostCategories> Categories { get; set; }

        public IList<PostTags> Tags { get; set; }
    }
}
