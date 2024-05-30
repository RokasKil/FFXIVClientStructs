namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

[Agent(AgentId.ReconstructionBox)]
[GenerateInterop]
[Inherits<AgentInterface>]
[StructLayout(LayoutKind.Explicit, Size = 0x240)]
public unsafe partial struct AgentReconstructionBox {
    [FieldOffset(0x50), FixedSizeArray] internal FixedSizeArray10<AgentItemDonationInfo> _donatedItems;

    [FieldOffset(0x21C)] public int LimitedTotal; // Actual Donation amount if it exceeds weekly budget
    [FieldOffset(0x220)] public int UnlimitedTotal; // Total attempted donation amount, can exceed weekly budget
}

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe struct AgentItemDonationInfo {
    [FieldOffset(0x00)] internal void* UnkPtr1;
    [FieldOffset(0x08)] internal void* UnkPtr2;
    [FieldOffset(0x10)] internal void* UnkPtr3;
}
