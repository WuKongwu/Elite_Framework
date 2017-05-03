using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite.Framework.Data.Entities
{
    public class SysUserRole
    {
        public int Id { get; set; }
        public int SysUserId { get; set; }
        public int SysRoleId { get; set; }
        public virtual SysUser SysUser { get; set;}
        public virtual SysRole SysRole { get; set; }
    }
}
