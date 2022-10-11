﻿namespace AppFramework.Domain
{
    public class BaseEntity
    {
        public long Id { get; set; }
        //public long Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }
}
