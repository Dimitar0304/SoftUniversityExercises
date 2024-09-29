﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string type, params string[] nameOfFieldsToHack)
        {
            StringBuilder result = new StringBuilder();
            Type obj = Type.GetType(type);

            List<FieldInfo> fields = new List<FieldInfo>();

            foreach (var item in nameOfFieldsToHack)
            {
                FieldInfo currentField = obj.GetField(item,BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance);
                fields.Add(currentField);
            }

            Object classInstance = Activator.CreateInstance(obj,new object[] { });


            foreach (FieldInfo field in fields)
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return result.ToString().Trim();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type obj = Type.GetType(className);
            StringBuilder result = new StringBuilder();

            FieldInfo[] publicFields =  obj.GetFields(BindingFlags.Public|BindingFlags.Instance|BindingFlags.Static);
            MethodInfo[] publicMethods = obj.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] privateMethods = obj.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in publicFields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }
            foreach (var publicMethod in publicMethods.Where(m=>m.Name.StartsWith("get")))
            {
                result.AppendLine($"{publicMethod.Name} have to be public");
            }
            foreach (var privateMethod in privateMethods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{privateMethod.Name} have to be private");
            }

            return result.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            Type obj = Type.GetType(className);
            StringBuilder result = new StringBuilder();

            MethodInfo[] publicMethods = obj.GetMethods(BindingFlags.NonPublic |
                BindingFlags.Instance|BindingFlags.Static);
                result.AppendLine($"All Private Methods of Class: {obj.FullName}");
                result.AppendLine($"Base Class: {obj.BaseType}");
            foreach (var item in publicMethods)
            {
                result.AppendLine(item.Name);
            }
            return result.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            Type obj = Type.GetType(className);
            StringBuilder result = new StringBuilder();
            MethodInfo[] allMethods = obj.GetMethods(BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Instance);
            foreach (var method in allMethods.Where(m=>m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in allMethods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return result.ToString().Trim();
        }
    }
}
