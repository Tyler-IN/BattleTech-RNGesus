using System.Diagnostics.CodeAnalysis;
using Harmony;

namespace RNGesus {
  [SuppressMessage("ReSharper", "UnusedMember.Global")]
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public static class RNGesus {
    public static void Init() {
      var harmony = HarmonyInstance.Create("RNGesus");
      harmony.PatchAll(typeof(RNGesus).Assembly);
    }
  }
}