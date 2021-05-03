using VoxelTycoon.Modding;
using VoxelTycoon.Researches;

namespace SkipResearch
{
    public class SkipResearch : Mod
    {
        protected override void OnGameStarted()
        {
            var manager = ResearchManager.Current;
            var researches = manager.GetAll();
            for (var i = 0; i < researches.Count; i++)
            {
                var research = researches[i];
                if (manager.IsCompleted(research)) continue;

                manager.Complete(research);
            }
        }
    }
}
