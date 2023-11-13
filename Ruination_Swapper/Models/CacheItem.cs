﻿using System.Collections.Generic;

namespace WebviewAppShared.Models
{
    public class CacheItem
    {
        public string Name;
        public string Id;
        public string WeaponAnim;
        public string Series;
        public string Path;
        public string DefinitionPath;
        public List<CacheMeshItem> Parts = new();
    }

    public class CacheMeshItem
    {
        public string Path;
        public string Mesh;
    }

}
