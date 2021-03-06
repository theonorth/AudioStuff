﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WavReader
{
  public static class NoteFrequencies
  {
    private static double _baseFreq = 440;
    private static double BaseFreq
    {
      get
      {
        return _baseFreq;
      }
      set
      {
        switch (value)
        {
          case 432:
          case 434:
          case 436:
          case 438:
          case 440:
          case 442:
          case 444:
          case 446:
            _baseFreq = value;
            break;
        }
      }
    }

    public static double C4 { get {
      }= 261.63;
    public const double D4 = 293.66;
    public const double E4 = 329.63;
    public const double F4 = 349.23;
    public const double G4 = 392.00;
    public const double A4 = 440.00;
  }
}
