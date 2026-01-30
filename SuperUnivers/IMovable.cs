namespace SuperUnivers;

public interface IMovable
{
    int X { get; set; }
    int Y { get; set; }
    int VitesseX { get; set; }
    int VitesseY { get; set; }
    void UpdateLocation(UniversPhysique univers);
}