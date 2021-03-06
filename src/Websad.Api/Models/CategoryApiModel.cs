﻿using System.Collections.Generic;
using Websad.Core.Enum;

namespace Websad.Api.Models {

    public class CategoryApiModel {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Lang { get; set; }
        public string PostType { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public EntityStatus Status { get; set; }
    }

    public class CategoryCreateApiModel {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Lang { get; set; }
        public string PostType { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Enabled;
    }

    public class CategoryListApiModel: ApiModel<IEnumerable<CategoryApiModel>> { 
        public CategoryListApiModel() { }

        public CategoryListApiModel(string postType)
            => PostType = postType;

        public string PostType { get; set; }
    }
}
