using Feedback.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feedback.Infrastructure.Configuration;

public class FeedbackConfiguration : IEntityTypeConfiguration<FeedbackItem>
{
    public void Configure(EntityTypeBuilder<FeedbackItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property("Score").IsRequired();
        builder.Property("Author").IsRequired();
        builder.Property("Subject").IsRequired();
        builder.Property("Publish Date").IsRequired();
    }
}