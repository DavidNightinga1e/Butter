namespace Butter
{
    public interface IClip
    {
        bool IsEnded { get; }
        void AddDelta(float t);
    }
}