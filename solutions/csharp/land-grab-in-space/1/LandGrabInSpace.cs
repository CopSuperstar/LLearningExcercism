using System;
using System.Collections.Generic;

public struct Coord
{
    public ushort X { get; }
    public ushort Y { get; }

    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }
}

public struct Plot
{
    public Coord C1 { get; }
    public Coord C2 { get; }
    public Coord C3 { get; }
    public Coord C4 { get; }

    public Plot(Coord c1, Coord c2, Coord c3, Coord c4)
    {
        C1 = c1;
        C2 = c2;
        C3 = c3;
        C4 = c4;
    }
}

public class ClaimsHandler
{
    private readonly HashSet<Plot> _registeredPlots = new HashSet<Plot>();
    private Plot _lastPlot;
    private int _biggestSide = -1;
    private Plot _bsplot;

    public void StakeClaim(Plot plot)
    {
        _registeredPlots.Add(plot);
        _lastPlot = plot;
    }

    public bool IsClaimStaked(Plot plot)
    {
        return _registeredPlots.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
        return _lastPlot.Equals(plot);
    }

    public Plot GetClaimWithLongestSide()
    {
        foreach (Plot p in _registeredPlots)
        {
            // Берем горизонтальную и вертикальную стороны
            int sideX = Math.Abs(p.C1.X - p.C2.X);
            int sideY = Math.Abs(p.C1.Y - p.C3.Y);
            
            int maxInPlot = sideX > sideY ? sideX : sideY;
            
            if (maxInPlot > _biggestSide)
            {
                _biggestSide = maxInPlot;
                _bsplot = p;
            }
        }
        return _bsplot;
    }
}
