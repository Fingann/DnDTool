namespace DnDTool.Core.Strategy
{
    using DnDTool.Core.Model.Character;

    public abstract class UpdateStrategy
    {
        public abstract void Update(Character charecter);
        public abstract void Update(Character charecter, object parameter);
    }
}

