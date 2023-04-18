﻿namespace ValueObjectExamples;

public class GuideWithVOs
{
    private GuideId id;
    private UserId ownerId;
    private CategoryId belongsToCategoryId;

    public GuideWithVOs(GuideId id, UserId ownerId, CategoryId belongsToCategoryId)
    {
        this.id = id;
        this.ownerId = ownerId;
        this.belongsToCategoryId = belongsToCategoryId;
    }

    private void example(UserId owner, CategoryId category)
    {
        GuideId guideId = new GuideId(Guid.NewGuid());
        GuideWithVOs guide0 = new GuideWithVOs(guideId, owner, category);
        // GuideWithVOs guide1 = new GuideWithVOs(owner, category, guideId);

    }
}

public class CategoryId
{
    public Guid Value { get; private set; }

    public CategoryId(Guid value)
    {
        Value = value;
        if (value == null) throw new InvalidArgumentException("Cannot be null");
    }
}

public class UserId
{
}

public class GuideId
{
    public GuideId(Guid newGuid)
    {
        throw new NotImplementedException();
    }
}