//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\rpcss.dll
// Interface ID: cb40a179-20e1-43f0-97fb-3c5c6ff37ec3
// Interface Version: 0.0



namespace rpc_cb40a179_20e1_43f0_97fb_3c5c6ff37ec3_0_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(short[] p0, long p1)
        {
            WriteConformantArray<short>(p0, p1);
        }
        public void Write_9(Struct_5[] p0, long p1)
        {
            WriteConformantStructArray<Struct_5>(p0, p1);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_12(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_13(Struct_7[] p0, long p1)
        {
            WriteConformantStructArray<Struct_7>(p0, p1);
        }
        public void Write_14(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_15(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_16(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_17(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_18(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_19(Struct_8[] p0, long p1)
        {
            WriteConformantStructArray<Struct_8>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public short[] Read_8()
        {
            return ReadConformantArray<short>();
        }
        public Struct_5[] Read_9()
        {
            return ReadConformantStructArray<Struct_5>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_11()
        {
            return ReadConformantArray<byte>();
        }
        public System.Guid[] Read_12()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public Struct_7[] Read_13()
        {
            return ReadConformantStructArray<Struct_7>();
        }
        public int[] Read_14()
        {
            return ReadConformantArray<int>();
        }
        public long[] Read_15()
        {
            return ReadConformantArray<long>();
        }
        public int[] Read_16()
        {
            return ReadConformantArray<int>();
        }
        public long[] Read_17()
        {
            return ReadConformantArray<long>();
        }
        public long[] Read_18()
        {
            return ReadConformantArray<long>();
        }
        public Struct_8[] Read_19()
        {
            return ReadConformantStructArray<Struct_8>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public short Member2;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(short Member0, short Member2)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member4 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public short Member2;
        public short[] Member4;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member4 = new short[0];
            return ret;
        }
        public Struct_1(short Member0, short Member2, short[] Member4)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_0(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteGuid(MemberC);
            m.WriteEmbeddedPointer<Struct_4>(Member20, new System.Action<Struct_4>(m.Write_3));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_0();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadGuid();
            Member20 = u.ReadEmbeddedPointer<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_0 Member0;
        public int Member4;
        public int Member8;
        public System.Guid MemberC;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4> Member20;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(Struct_0 Member0, int Member4, int Member8, System.Guid MemberC, System.Nullable<Struct_4> Member20)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member20 = Member20;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<Struct_5[], long>(Member8, new System.Action<Struct_5[], long>(m.Write_9), NtApiDotNet.Win32.Rpc.RpcUtils.OpBitwiseAnd(NtApiDotNet.Win32.Rpc.RpcUtils.OpPlus(Member0, 1), -2));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_5[]>(new System.Func<Struct_5[]>(u.Read_9), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_5[]> Member8;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, int Member4, Struct_5[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.WriteInt32(Member10);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member14, "Member14"), NtApiDotNet.Win32.Rpc.RpcUtils.OpBitwiseAnd(NtApiDotNet.Win32.Rpc.RpcUtils.OpPlus(Member10, 7), -8));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt32();
            Member14 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public int Member10;
        public byte[] Member14;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member14 = new byte[0];
            return ret;
        }
        public Struct_5(System.Guid Member0, int Member10, byte[] Member14)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<Struct_4>(Member8, new System.Action<Struct_4>(m.Write_3));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4> Member8;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, System.Nullable<Struct_4> Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_11();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public byte[] Member4;
        public static Struct_7 CreateDefault()
        {
            Struct_7 ret = new Struct_7();
            ret.Member4 = new byte[0];
            return ret;
        }
        public Struct_7(int Member0, byte[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public int Member8;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(long Member0, int Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("cb40a179-20e1-43f0-97fb-3c5c6ff37ec3", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint GetCrossContainerServerInfo(out Struct_0 p0, out System.Nullable<Struct_1> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.Read_0();
            p1 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            return u.ReadUInt32();
        }
        public uint CreateCrossContainerOidSet(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint DeleteCrossContainerOidSet(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint CrossContainerActivation(
                    NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, 
                    Struct_2 p1, 
                    out Struct_6 p2, 
                    System.Nullable<System.Guid> p3, 
                    string p4, 
                    int p5, 
                    int p6, 
                    int p7, 
                    System.Guid[] p8, 
                    out long p9, 
                    out System.Nullable<Struct_1> p10, 
                    out System.Guid p11, 
                    out long p12, 
                    out System.Guid p13, 
                    out Struct_0 p14, 
                    out int p15, 
                    out Struct_7[] p16, 
                    out int[] p17)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_2(p1);
            m.WriteReferent(p3, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p8, "p8"), p7);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.Read_5();
            p9 = u.ReadInt64();
            p10 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p11 = u.ReadGuid();
            p12 = u.ReadInt64();
            p13 = u.ReadGuid();
            p14 = u.Read_0();
            p15 = u.ReadInt32();
            p16 = u.Read_13();
            p17 = u.Read_14();
            return u.ReadUInt32();
        }
        public uint CrossContainerResolveOxid(long p0, out System.Nullable<Struct_1> p1, out System.Guid p2, out long p3, out System.Guid p4, out Struct_0 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p2 = u.ReadGuid();
            p3 = u.ReadInt64();
            p4 = u.ReadGuid();
            p5 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint CrossContainerBulkUpdateOids(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, long[] p2, out int[] p3, int p4, long[] p5, int p6, long[] p7, int p8, Struct_8[] p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p4);
            m.Write_17(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p4);
            m.WriteInt32(p6);
            m.Write_18(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p6);
            m.WriteInt32(p8);
            m.Write_19(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p9, "p9"), p8);
            _Unmarshal_Helper u = SendReceive(5, m);
            p3 = u.Read_16();
            return u.ReadUInt32();
        }
    }
    #endregion
}

