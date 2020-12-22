using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MangoBlog.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoBlog.Data.TypeConfigurations
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(StringLength.Identity)
                .IsRequired()
                .HasComment("식별자");

            builder.Property(x => x.DisplayName)
                .HasMaxLength(StringLength.Name)
                .IsRequired()
                .HasComment("이름");
            builder.Property(x => x.Email)
                .HasMaxLength(StringLength.Email)
                .IsRequired()
                .HasComment("전자우편주소");
            builder.Property(x => x.IsEmailVertified)
                .IsRequired()
                .HasDefaultValue(false)
                .HasComment("전자우편주소 확인 여부");
            builder.Property(x => x.IsEnabled)
                .IsRequired()
                .HasDefaultValue(true)
                .HasComment("사용여부");
            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false)
                .HasComment("삭제여부");
        }
    }

    internal class StringLength
    {
        public static int Identity = 36;
        public static int Name = 200;
        public static int Title = 1000;
        public static int Email = 200;
    }
}
