//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting
    {
        public int Id { get; set; }
        public System.DateTime Data { get; set; }
        public System.TimeSpan Time { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
    }
}
