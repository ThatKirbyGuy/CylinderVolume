using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CylinderVolume;

namespace CylinderVolumeGeometry
{
    [TestClass]
    public class CylinderGeometry
    {
        [TestMethod]
        public void CylinderVolume_return()
        {
            // исходные данные
            int S = 7;
            int h = 8;
            int V = 56;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.CylinderVolume(S, h);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(V, actual);

        }
    }
}
