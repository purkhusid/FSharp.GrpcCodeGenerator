// <auto-generated>
//     Generated by the F# GRPC code generator. DO NOT EDIT!
//     source: google/protobuf/timestamp.proto
// </auto-generated>
namespace rec Google.Protobuf.FSharp.WellKnownTypes
#nowarn "40"
module TimestampReflection =
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal Timestamp_Descriptor() = Descriptor().MessageTypes.[0]
    let private descriptorBackingField: global.System.Lazy<global.Google.Protobuf.Reflection.FileDescriptor> =
        let descriptorData = global.System.Convert.FromBase64String("\
            Ch9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvEg9nb29nbGUucHJvdG9idWYiOwoJVGltZXN0\
            YW1wEhgKB3NlY29uZHMYASABKANSB3NlY29uZHMSFAoFbmFub3MYAiABKAVSBW5hbm9zQoUBChNjb20u\
            Z29vZ2xlLnByb3RvYnVmQg5UaW1lc3RhbXBQcm90b1ABWjJnb29nbGUuZ29sYW5nLm9yZy9wcm90b2J1\
            Zi90eXBlcy9rbm93bi90aW1lc3RhbXBwYvgBAaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25v\
            d25UeXBlc2IGcHJvdG8z")
        global.System.Lazy<_>(
            (fun () ->
                global.Google.Protobuf.Reflection.FileDescriptor.FromGeneratedCode(
                    descriptorData,
                    [|
                    |],
                    new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(
                        null,
                        null,
                        [|
                            new global.Google.Protobuf.Reflection.GeneratedClrTypeInfo(typeof<global.Google.Protobuf.FSharp.WellKnownTypes.Timestamp>, global.Google.Protobuf.FSharp.WellKnownTypes.Timestamp.Parser, [| "Seconds"; "Nanos" |], null, null, null, null)
                        |]
                    )
                )
            ),
            true
        )
    let Descriptor(): global.Google.Protobuf.Reflection.FileDescriptor = descriptorBackingField.Value
type Timestamp = {
    mutable _UnknownFields: global.Google.Protobuf.UnknownFieldSet
    mutable Seconds: ValueOption<int64>
    mutable Nanos: ValueOption<int32>
} with
    // Start of hand-written code
    static member FromDateTime(dt: System.DateTime) : Timestamp =
        let ticks = (dt.ToUniversalTime() - Timestamp.unixEpoch).Ticks
        let seconds = ticks / System.TimeSpan.TicksPerSecond
        let nanos = int ((ticks % System.TimeSpan.TicksPerSecond) * 100L)
        { Timestamp.empty() with
            Seconds = ValueSome seconds
            Nanos = ValueSome nanos
        }
    member me.ToDateTime() : ValueOption<System.DateTime> =
        match me.Seconds with
        | ValueNone -> ValueNone
        | ValueSome secs ->
            let nanos = ValueOption.defaultValue 0 me.Nanos
            let ticks = int64 nanos / 100L + secs * System.TimeSpan.TicksPerSecond
            ValueSome(Timestamp.unixEpoch.AddTicks(ticks))
    member me.ToDateTimeOffset() : ValueOption<System.DateTimeOffset> =
        match me.Seconds with
        | ValueNone -> ValueNone
        | ValueSome secs ->
            let nanos = ValueOption.defaultValue 0 me.Nanos
            let ticks = int64 nanos / 100L + secs * System.TimeSpan.TicksPerSecond
            ValueSome(System.DateTimeOffset(Timestamp.unixEpoch.AddTicks(ticks)))
    // End of hand-written code
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member me.Clone() : Timestamp = {
        Timestamp._UnknownFields = global.Google.Protobuf.UnknownFieldSet.Clone(me._UnknownFields)
        Timestamp.Seconds = me.Seconds
        Timestamp.Nanos = me.Nanos
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalWriteTo(output: byref<global.Google.Protobuf.WriteContext>) =
        if me.Seconds <> ValueNone
        then
            output.WriteRawTag(8uy)
            output.WriteInt64(me.Seconds.Value)
        if me.Nanos <> ValueNone
        then
            output.WriteRawTag(16uy)
            output.WriteInt32(me.Nanos.Value)
        if not <| isNull me._UnknownFields then me._UnknownFields.WriteTo(&output)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.CalculateSize() =
        let mutable size = 0
        if me.Seconds <> ValueNone then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeInt64Size(me.Seconds.Value)
        if me.Nanos <> ValueNone then size <- size + 1 + global.Google.Protobuf.CodedOutputStream.ComputeInt32Size(me.Nanos.Value)
        if not <| isNull me._UnknownFields then size <- size + me._UnknownFields.CalculateSize()
        size
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.MergeFrom(other: Timestamp) =
        if other.Seconds <> ValueNone
        then me.Seconds <- other.Seconds
        if other.Nanos <> ValueNone
        then me.Nanos <- other.Nanos
        me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFrom(me._UnknownFields, other._UnknownFields)
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    member private me.InternalMergeFrom(input: byref<global.Google.Protobuf.ParseContext>) =
        let mutable tag = input.ReadTag()
        while tag <> 0u do
            match tag with
            | 8u ->
                me.Seconds <- ValueSome(input.ReadInt64())
            | 16u ->
                me.Nanos <- ValueSome(input.ReadInt32())
            | _ ->
                me._UnknownFields <- global.Google.Protobuf.UnknownFieldSet.MergeFieldFrom(me._UnknownFields, &input)
            tag <- input.ReadTag()
    interface global.Google.Protobuf.IBufferMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalMergeFrom(ctx) = me.InternalMergeFrom(&ctx)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.InternalWriteTo(ctx) = me.InternalWriteTo(&ctx)
    interface global.Google.Protobuf.IMessage<Timestamp> with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.Clone() = me.Clone()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(other) = me.MergeFrom(other)
    interface global.Google.Protobuf.IMessage with
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.CalculateSize() = me.CalculateSize()
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.MergeFrom(input) = input.ReadRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member me.WriteTo(output) = output.WriteRawMessage(me)
        [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
        member __.Descriptor = global.Google.Protobuf.FSharp.WellKnownTypes.TimestampReflection.Timestamp_Descriptor()
module Timestamp =
    // Start of hand-written code
    let internal unixEpoch : System.DateTime = System.DateTime.Parse("1970-01-01T00:00:00Z")
    // End of hand-written code
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let internal DefaultValue = {
        Timestamp._UnknownFields = null
        Timestamp.Seconds = ValueNone
        Timestamp.Nanos = ValueNone
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let empty () = {
        Timestamp._UnknownFields = null
        Timestamp.Seconds = ValueNone
        Timestamp.Nanos = ValueNone
    }
    [<global.System.Diagnostics.DebuggerNonUserCodeAttribute>]
    let Parser = global.Google.Protobuf.MessageParser<Timestamp>(global.System.Func<_>(empty))
    let SecondsFieldNumber = 1
    let NanosFieldNumber = 2
// End of auto-generated code
