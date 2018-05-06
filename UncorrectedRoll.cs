using System.Diagnostics.CodeAnalysis;
using Harmony;
using BattleTech;

namespace RNGesus {
  [HarmonyPatch(typeof(AttackDirector.AttackSequence),"GetCorrectedRoll")]
  [SuppressMessage("ReSharper", "UnusedMember.Global")]
  public static class UncorrectedRoll {
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static bool Prefix(float roll, out float __result) {
      __result = roll;
      return false;
    }
  }
}