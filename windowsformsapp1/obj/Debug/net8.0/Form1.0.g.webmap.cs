#pragma warning disable
#line 1 "Form1.cs"
#line hidden
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace WindowsFormsApp1
{
    public partial class Form1
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[5];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_components) > 0)
            {
                yield return "components";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_label1) > 0)
            {
                yield return "label1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_button1) > 0)
            {
                yield return "button1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_textBox1) > 0)
            {
                yield return "textBox1";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_label2) > 0)
            {
                yield return "label2";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "components":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_components) > 0;
                case "label1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_label1) > 0;
                case "button1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_button1) > 0;
                case "textBox1":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_textBox1) > 0;
                case "label2":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_label2) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["components"] = _Mobilize_References[0];
            refs["label1"] = _Mobilize_References[1];
            refs["button1"] = _Mobilize_References[2];
            refs["textBox1"] = _Mobilize_References[3];
            refs["label2"] = _Mobilize_References[4];
            return refs;
        }

        protected override void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_LoadedFlag_0 = 0;
                this._Mobilize_ControlFlag = 0;
            }

            base._Mobilize_CleanChanges();
        }

        protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
        {
            foreach (var baseRef in base._Mobilize_GetReferences())
            {
                yield return baseRef;
            }

            var ref_components = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.components);
            if (ref_components != null)
                yield return ref_components;
            var ref_label1 = (Mobilize.WebMap.Common.Core.IObservable)this.label1;
            if (ref_label1 != null)
                yield return ref_label1;
            var ref_button1 = (Mobilize.WebMap.Common.Core.IObservable)this.button1;
            if (ref_button1 != null)
                yield return ref_button1;
            var ref_textBox1 = (Mobilize.WebMap.Common.Core.IObservable)this.textBox1;
            if (ref_textBox1 != null)
                yield return ref_textBox1;
            var ref_label2 = (Mobilize.WebMap.Common.Core.IObservable)this.label2;
            if (ref_label2 != null)
                yield return ref_label2;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_components = (uint)1 << 0;
        const uint _Mobilize_Loaded_components = (uint)1 << 0;
        const uint _Mobilize_Dirty_label1 = (uint)1 << 1;
        const uint _Mobilize_Loaded_label1 = (uint)1 << 1;
        const uint _Mobilize_Dirty_button1 = (uint)1 << 2;
        const uint _Mobilize_Loaded_button1 = (uint)1 << 2;
        const uint _Mobilize_Dirty_textBox1 = (uint)1 << 3;
        const uint _Mobilize_Loaded_textBox1 = (uint)1 << 3;
        const uint _Mobilize_Dirty_label2 = (uint)1 << 4;
        const uint _Mobilize_Loaded_label2 = (uint)1 << 4;
        private void Mobilize_Initialize_Properties()
        {
            this.components = null;
#line hidden
        }
#line 17
    }
}