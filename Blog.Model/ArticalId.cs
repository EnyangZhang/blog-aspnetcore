using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Blog.Model
{
    /// <summary>
    /// Represents the model for storing article IDs.
    /// </summary>
    public class ArticalId
    {
        /// <summary>
        /// Gets or sets the unique identifier for the article.
        /// </summary>
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id {
            get;
            set;
        }
    }
}
