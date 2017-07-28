using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPatternSimple
{

    /// <summary>
    /// This is a SIMPLE Factory Pattern Example 
    ///     that makes use of reflection to get types
    /// </summary>
    public class AutoFactory
    {
        #region Init
        private Dictionary<string, Type> autos = new Dictionary<string, Type>();

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }
        #endregion


        #region Methods

        public IAuto CreateInstance(string carName)
        {
            Type type = this.GetTypeToCreate(carName);
            if (type == null)
            {
                return new NullAuto();
            }
            return Activator.CreateInstance(type) as IAuto;
        }

        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(type.Name, type);
                }
            }
        }
        #endregion
    }
}
