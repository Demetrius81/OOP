
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0



// Classes defined in this module:
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Class Demo                           (public) (abstract) (auto) (ansi) (sealed) 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:2:2:0
}
.assembly extern System.Collections
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:1:2:0
}
.assembly extern Interfaces
{
  .ver 1:0:0:0
}
.assembly extern Factory
{
  .ver 1:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:1:2:0
}
.assembly Demo
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 33 2E 31 01 00 54 0E 14   // ersion=v3.1..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 04 44 65 6D 6F 00 00 )                      // ...Demo..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 04 44 65 6D 6F 00 00 )                      // ...Demo..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 04 44 65 6D 6F 00 00 )                      // ...Demo..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Demo.dll
// MVID: {53911E61-42DA-4ED1-B836-F1F6F58BCA40}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x0B9A0000


// =============== CLASS MEMBERS DECLARATION ===================

.class public abstract auto ansi sealed beforefieldinit Constructions.Demo
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Test() cil managed
  {
    // Размер кода:       290 (0x122)
    .maxstack  5
    .locals init (valuetype [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<int32,class [Interfaces]Constructions.IBuilding> V_0,
             int32 V_1,
             class [Interfaces]Constructions.IBuilding V_2)
    IL_0000:  nop
    IL_0001:  ldc.i4.3
    IL_0002:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32)
    IL_0007:  ldc.i4.1
    IL_0008:  ldc.i4.1
    IL_0009:  ldc.i4.1
    IL_000a:  call       void [Factory]Constructions.Creator::CreateBuild(valuetype [System.Runtime]System.Decimal,
                                                                          int32,
                                                                          int32,
                                                                          int32)
    IL_000f:  nop
    IL_0010:  ldc.i4.7
    IL_0011:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32)
    IL_0016:  ldc.i4.2
    IL_0017:  ldc.i4.3
    IL_0018:  ldc.i4.s   12
    IL_001a:  call       void [Factory]Constructions.Creator::CreateBuild(valuetype [System.Runtime]System.Decimal,
                                                                          int32,
                                                                          int32,
                                                                          int32)
    IL_001f:  nop
    IL_0020:  ldc.i4.s   12
    IL_0022:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32)
    IL_0027:  ldc.i4.3
    IL_0028:  ldc.i4.2
    IL_0029:  ldc.i4.s   12
    IL_002b:  call       void [Factory]Constructions.Creator::CreateBuild(valuetype [System.Runtime]System.Decimal,
                                                                          int32,
                                                                          int32,
                                                                          int32)
    IL_0030:  nop
    IL_0031:  ldc.i4     0x9ab
    IL_0036:  ldc.i4.0
    IL_0037:  ldc.i4.0
    IL_0038:  ldc.i4.0
    IL_0039:  ldc.i4.2
    IL_003a:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32,
                                                                             int32,
                                                                             int32,
                                                                             bool,
                                                                             uint8)
    IL_003f:  ldc.i4.s   9
    IL_0041:  ldc.i4.2
    IL_0042:  ldc.i4.s   72
    IL_0044:  call       void [Factory]Constructions.Creator::CreateBuild(valuetype [System.Runtime]System.Decimal,
                                                                          int32,
                                                                          int32,
                                                                          int32)
    IL_0049:  nop
    IL_004a:  ldc.i4     0x107
    IL_004f:  ldc.i4.0
    IL_0050:  ldc.i4.0
    IL_0051:  ldc.i4.0
    IL_0052:  ldc.i4.1
    IL_0053:  newobj     instance void [System.Runtime]System.Decimal::.ctor(int32,
                                                                             int32,
                                                                             int32,
                                                                             bool,
                                                                             uint8)
    IL_0058:  ldc.i4.s   10
    IL_005a:  ldc.i4.4
    IL_005b:  ldc.i4     0xa0
    IL_0060:  call       void [Factory]Constructions.Creator::CreateBuild(valuetype [System.Runtime]System.Decimal,
                                                                          int32,
                                                                          int32,
                                                                          int32)
    IL_0065:  nop
    IL_0066:  nop
    IL_0067:  call       class [System.Collections]System.Collections.Generic.Dictionary`2<int32,class [Interfaces]Constructions.IBuilding> [Factory]Constructions.Creator::get_Buildings()
    IL_006c:  callvirt   instance class [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection<!0,!1> class [System.Collections]System.Collections.Generic.Dictionary`2<int32,class [Interfaces]Constructions.IBuilding>::get_Keys()
    IL_0071:  callvirt   instance valuetype [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<!0,!1> class [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection<int32,class [Interfaces]Constructions.IBuilding>::GetEnumerator()
    IL_0076:  stloc.0
    .try
    {
      IL_0077:  br         IL_00fe

      IL_007c:  ldloca.s   V_0
      IL_007e:  call       instance !0 valuetype [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<int32,class [Interfaces]Constructions.IBuilding>::get_Current()
      IL_0083:  stloc.1
      IL_0084:  nop
      IL_0085:  call       class [System.Collections]System.Collections.Generic.Dictionary`2<int32,class [Interfaces]Constructions.IBuilding> [Factory]Constructions.Creator::get_Buildings()
      IL_008a:  ldloc.1
      IL_008b:  ldloca.s   V_2
      IL_008d:  callvirt   instance bool class [System.Collections]System.Collections.Generic.Dictionary`2<int32,class [Interfaces]Constructions.IBuilding>::TryGetValue(!0,
                                                                                                                                                                         !1&)
      IL_0092:  pop
      IL_0093:  ldc.i4.5
      IL_0094:  newarr     [System.Runtime]System.String
      IL_0099:  dup
      IL_009a:  ldc.i4.0
      IL_009b:  ldloc.2
      IL_009c:  callvirt   instance string [System.Runtime]System.Object::ToString()
      IL_00a1:  stelem.ref
      IL_00a2:  dup
      IL_00a3:  ldc.i4.1
      IL_00a4:  ldstr      ","
      IL_00a9:  stelem.ref
      IL_00aa:  dup
      IL_00ab:  ldc.i4.2
      IL_00ac:  ldstr      bytearray (20 00 32 04 4B 04 41 04 3E 04 42 04 30 04 20 00   //  .2.K.A.>.B.0. .
                                      3F 04 3E 04 42 04 3E 04 3B 04 3A 04 3E 04 32 04   // ?.>.B.>.;.:.>.2.
                                      20 00 7B 00 30 00 7D 00 3C 04 2E 00 )             //  .{.0.}.<...
      IL_00b1:  ldloc.2
      IL_00b2:  callvirt   instance valuetype [System.Runtime]System.Decimal [Interfaces]Constructions.IBuilding::FloorHeightCalculate()
      IL_00b7:  box        [System.Runtime]System.Decimal
      IL_00bc:  call       string [System.Runtime]System.String::Format(string,
                                                                        object)
      IL_00c1:  stelem.ref
      IL_00c2:  dup
      IL_00c3:  ldc.i4.3
      IL_00c4:  ldstr      bytearray (20 00 1A 04 3E 04 3B 04 38 04 47 04 35 04 41 04   //  ...>.;.8.G.5.A.
                                      42 04 32 04 3E 04 20 00 3A 04 32 04 30 04 40 04   // B.2.>. .:.2.0.@.
                                      42 04 38 04 40 04 20 00 32 04 20 00 3F 04 3E 04   // B.8.@. .2. .?.>.
                                      34 04 4A 04 35 04 37 04 34 04 35 04 20 00 7B 00   // 4.J.5.7.4.5. .{.
                                      30 00 7D 00 2C 00 )                               // 0.}.,.
      IL_00c9:  ldloc.2
      IL_00ca:  callvirt   instance int32 [Interfaces]Constructions.IBuilding::NumberOfApartmentInEntranceCalculate()
      IL_00cf:  box        [System.Runtime]System.Int32
      IL_00d4:  call       string [System.Runtime]System.String::Format(string,
                                                                        object)
      IL_00d9:  stelem.ref
      IL_00da:  dup
      IL_00db:  ldc.i4.4
      IL_00dc:  ldstr      bytearray (20 00 3A 04 3E 04 3B 04 38 04 47 04 35 04 41 04   //  .:.>.;.8.G.5.A.
                                      42 04 32 04 3E 04 20 00 3A 04 32 04 30 04 40 04   // B.2.>. .:.2.0.@.
                                      42 04 38 04 40 04 20 00 3D 04 30 04 20 00 4D 04   // B.8.@. .=.0. .M.
                                      42 04 30 04 36 04 35 04 20 00 7B 00 30 00 7D 00   // B.0.6.5. .{.0.}.
                                      2E 00 )                                           // ..
      IL_00e1:  ldloc.2
      IL_00e2:  callvirt   instance int32 [Interfaces]Constructions.IBuilding::NumberOfApartmentOnFloorCalculate()
      IL_00e7:  box        [System.Runtime]System.Int32
      IL_00ec:  call       string [System.Runtime]System.String::Format(string,
                                                                        object)
      IL_00f1:  stelem.ref
      IL_00f2:  call       string [System.Runtime]System.String::Concat(string[])
      IL_00f7:  call       void [System.Console]System.Console::WriteLine(string)
      IL_00fc:  nop
      IL_00fd:  nop
      IL_00fe:  ldloca.s   V_0
      IL_0100:  call       instance bool valuetype [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<int32,class [Interfaces]Constructions.IBuilding>::MoveNext()
      IL_0105:  brtrue     IL_007c

      IL_010a:  leave.s    IL_011b

    }  // end .try
    finally
    {
      IL_010c:  ldloca.s   V_0
      IL_010e:  constrained. valuetype [System.Collections]System.Collections.Generic.Dictionary`2/KeyCollection/Enumerator<int32,class [Interfaces]Constructions.IBuilding>
      IL_0114:  callvirt   instance void [System.Runtime]System.IDisposable::Dispose()
      IL_0119:  nop
      IL_011a:  endfinally
    }  // end handler
    IL_011b:  call       valuetype [System.Console]System.ConsoleKeyInfo [System.Console]System.Console::ReadKey()
    IL_0120:  pop
    IL_0121:  ret
  } // end of method Demo::Test

} // end of class Constructions.Demo


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\проекты\GB\OOP\Lesson4\Lesson4\bin\Debug\netcoreapp3.1\FromILDASM.res
