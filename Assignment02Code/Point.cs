using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02Code
{
    #region Point3d Project 1
    //internal class Point3D : IComparable<Point3D>, ICloneable
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }  
    //    public int Z { get; set; }
    //    public Point3D(int x) : this (x, 0 , 0) 
    //    {
           
    //    }

    //    public Point3D(int x, int y) : this (x, y, 0) 
    //    {
          
            
    //    }

    //    public  Point3D(int x, int y, int z) 
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;

    //    }

    //    public override string ToString()
    //    {
    //        return $" X :{X} , Y : {Y}, Z : {Z}"; 

    //    }

    //    public override bool Equals(object ? obj)
    //    {
    //          if(obj is Point3D p)
    //            return X==p.X && Y==p.Y && Z==p.Z ;
    //          return false ;

    //    }
    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(X, Y, Z);
    //    }

    //    public static bool operator ==(Point3D a, Point3D b)
    //    {
    //        if (ReferenceEquals(a, b)) return true;
    //        if ( a is null || b is null ) return false; 
    //        return a.Equals(b);

    //    }
    //    public static bool operator !=(Point3D a , Point3D  b)
    //    {

    //        return !(a == b);
    //    }

    //    public int CompareTo(Point3D point)
    //    {
    //        if (point == null)
    //            return 1;

    //       int compareX= this.X.CompareTo(point.X);
    //        if (compareX != 0)
    //            return compareX;

    //        int compareY = this.Y.CompareTo(point.Y);
    //        if (compareY != 0) return compareY;

    //        return this.Z.CompareTo(point.Z);

    //    }

    //    public object Clone()
    //    { 
    //       return new Point3D(this.X,this.Y,this.Z);
        
    //    }



    //}

    #endregion


}
