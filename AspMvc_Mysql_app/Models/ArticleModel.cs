using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspMvc_Mysql_app.Models
{
    /*
     DROP TABLE Articles;
     CREATE TABLE Articles  (
         ID  INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
         Title VARCHAR(20) NOT NULL ,
        Content TEXT NOT NULL 
       );
     */
    public class Article
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}