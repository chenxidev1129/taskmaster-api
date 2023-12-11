﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using taskmaster_api.Data.DTOs;
using taskmaster_api.Data.Entities.Interface;
using taskmaster_api.Utilities;
using Microsoft.AspNetCore.Identity;

namespace taskmaster_api.Data.Entities
{
    public class CommentEntity : IEntity<CommentDto>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Required]
        public int TaskId { get; set; }
        public TaskEntity Task { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public CommentDto ToDto()
        {
            return EntityHelpers.ToDto<CommentEntity, CommentDto>(this);
        }
    }
}
