using System.Reflection;
using System.Reflection.Emit;

namespace ChocolArm64.Translation
{
    struct ILOpCodeCall : IILEmit
    {
        public MethodInfo Info { get; private set; }

        public ILOpCodeCall(MethodInfo info)
        {
            Info = info;
        }

        public void Emit(ILMethodBuilder context)
        {
            context.Generator.Emit(OpCodes.Call, Info);
        }
    }
}