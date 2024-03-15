using System;

namespace Scripts.Infrastructure.Services.LoadLevels
{
    public interface ILoadLevelService
    {
        public void Load(string name, Action onLoadLevel);
    }
}