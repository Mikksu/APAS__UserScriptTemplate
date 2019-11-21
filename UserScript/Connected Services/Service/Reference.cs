﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserScript.Service {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SSC_MoveMode", Namespace="http://schemas.datacontract.org/2004/07/SystemServiceContract.Core")]
    public enum SSC_MoveMode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REL = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ABS = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SSC_IOTypeEnum", Namespace="http://schemas.datacontract.org/2004/07/SystemServiceContract.Core")]
    public enum SSC_IOTypeEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Input = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Output = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SSC_IOStatusEnum", Namespace="http://schemas.datacontract.org/2004/07/SystemServiceContract.Core")]
    public enum SSC_IOStatusEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Disabled = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Enabled = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SSC_PMUnitEnum", Namespace="http://schemas.datacontract.org/2004/07/SystemServiceContract.Core")]
    public enum SSC_PMUnitEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        dBm = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        dB = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        mW = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        mA = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SSC_PMRangeEnum", Namespace="http://schemas.datacontract.org/2004/07/SystemServiceContract.Core")]
    public enum SSC_PMRangeEnum : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range1 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range2 = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range3 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range4 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range5 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range6 = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.ISystemService")]
    public interface ISystemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogInfo", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogInfoResponse")]
        void @__SSC_LogInfo(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogInfo", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogInfoResponse")]
        System.Threading.Tasks.Task @__SSC_LogInfoAsync(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogError", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogErrorResponse")]
        void @__SSC_LogError(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogError", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogErrorResponse")]
        System.Threading.Tasks.Task @__SSC_LogErrorAsync(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogWarn", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogWarnResponse")]
        void @__SSC_LogWarn(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_LogWarn", ReplyAction="http://tempuri.org/ISystemService/__SSC_LogWarnResponse")]
        System.Threading.Tasks.Task @__SSC_LogWarnAsync(string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Connect", ReplyAction="http://tempuri.org/ISystemService/__SSC_ConnectResponse")]
        void @__SSC_Connect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Connect", ReplyAction="http://tempuri.org/ISystemService/__SSC_ConnectResponse")]
        System.Threading.Tasks.Task @__SSC_ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Disonnect", ReplyAction="http://tempuri.org/ISystemService/__SSC_DisonnectResponse")]
        void @__SSC_Disonnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Disonnect", ReplyAction="http://tempuri.org/ISystemService/__SSC_DisonnectResponse")]
        System.Threading.Tasks.Task @__SSC_DisonnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_SequenceStop", ReplyAction="http://tempuri.org/ISystemService/__SSC_SequenceStopResponse")]
        void @__SSC_SequenceStop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_SequenceStop", ReplyAction="http://tempuri.org/ISystemService/__SSC_SequenceStopResponse")]
        System.Threading.Tasks.Task @__SSC_SequenceStopAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MeasurableDevice_Read", ReplyAction="http://tempuri.org/ISystemService/__SSC_MeasurableDevice_ReadResponse")]
        double @__SSC_MeasurableDevice_Read(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MeasurableDevice_Read", ReplyAction="http://tempuri.org/ISystemService/__SSC_MeasurableDevice_ReadResponse")]
        System.Threading.Tasks.Task<double> @__SSC_MeasurableDevice_ReadAsync(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MoveAxis", ReplyAction="http://tempuri.org/ISystemService/__SSC_MoveAxisResponse")]
        void @__SSC_MoveAxis(string Aligner, string Axis, UserScript.Service.SSC_MoveMode Mode, int Speed, double Distance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MoveAxis", ReplyAction="http://tempuri.org/ISystemService/__SSC_MoveAxisResponse")]
        System.Threading.Tasks.Task @__SSC_MoveAxisAsync(string Aligner, string Axis, UserScript.Service.SSC_MoveMode Mode, int Speed, double Distance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MoveToPresetPosition", ReplyAction="http://tempuri.org/ISystemService/__SSC_MoveToPresetPositionResponse")]
        void @__SSC_MoveToPresetPosition(string MotionComp, string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_MoveToPresetPosition", ReplyAction="http://tempuri.org/ISystemService/__SSC_MoveToPresetPositionResponse")]
        System.Threading.Tasks.Task @__SSC_MoveToPresetPositionAsync(string MotionComp, string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_GetAbsPosition", ReplyAction="http://tempuri.org/ISystemService/__SSC_GetAbsPositionResponse")]
        double @__SSC_GetAbsPosition(string Aligner, string Axis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_GetAbsPosition", ReplyAction="http://tempuri.org/ISystemService/__SSC_GetAbsPositionResponse")]
        System.Threading.Tasks.Task<double> @__SSC_GetAbsPositionAsync(string Aligner, string Axis);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_ShowImage", ReplyAction="http://tempuri.org/ISystemService/__SSC_ShowImageResponse")]
        void @__SSC_ShowImage(System.Drawing.Bitmap Image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_ShowImage", ReplyAction="http://tempuri.org/ISystemService/__SSC_ShowImageResponse")]
        System.Threading.Tasks.Task @__SSC_ShowImageAsync(System.Drawing.Bitmap Image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_ReadIO", ReplyAction="http://tempuri.org/ISystemService/__SSC_ReadIOResponse")]
        UserScript.Service.SSC_IOStatusEnum @__SSC_ReadIO(string IO, UserScript.Service.SSC_IOTypeEnum IOType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_ReadIO", ReplyAction="http://tempuri.org/ISystemService/__SSC_ReadIOResponse")]
        System.Threading.Tasks.Task<UserScript.Service.SSC_IOStatusEnum> @__SSC_ReadIOAsync(string IO, UserScript.Service.SSC_IOTypeEnum IOType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_WriteIO", ReplyAction="http://tempuri.org/ISystemService/__SSC_WriteIOResponse")]
        void @__SSC_WriteIO(string IO, UserScript.Service.SSC_IOStatusEnum Status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_WriteIO", ReplyAction="http://tempuri.org/ISystemService/__SSC_WriteIOResponse")]
        System.Threading.Tasks.Task @__SSC_WriteIOAsync(string IO, UserScript.Service.SSC_IOStatusEnum Status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoBlindSearch", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoBlindSearchResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoBlindSearch(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoBlindSearch", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoBlindSearchResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoBlindSearchAsync(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/DoBlindSearchWithParam", ReplyAction="http://tempuri.org/ISystemService/DoBlindSearchWithParamResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object DoBlindSearchWithParam(string Aligner, string HorizontalAxis, string VerticalAxis, double Interval, double Range, int Speed, int AnalogCaptureChannel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/DoBlindSearchWithParam", ReplyAction="http://tempuri.org/ISystemService/DoBlindSearchWithParamResponse")]
        System.Threading.Tasks.Task<object> DoBlindSearchWithParamAsync(string Aligner, string HorizontalAxis, string VerticalAxis, double Interval, double Range, int Speed, int AnalogCaptureChannel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFast1D", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFast1DResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoFast1D(string Aligner, string Axis, double Interval, double Range, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFast1D", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFast1DResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoFast1DAsync(string Aligner, string Axis, double Interval, double Range, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFastND", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFastNDResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoFastND(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFastND", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFastNDResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoFastNDAsync(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFastAngleTuning", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFastAngleTuningResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoFastAngleTuning(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoFastAngleTuning", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoFastAngleTuningResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoFastAngleTuningAsync(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/DoFastAngleTuningWithParam", ReplyAction="http://tempuri.org/ISystemService/DoFastAngleTuningWithParamResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object DoFastAngleTuningWithParam(string Aligner, string LinearAxis, double LinearInterval, double LinearRange, int Speed, double Pitch, int AnalogCaptureChannel1, int AnalogCaptureChannel2, string RotatingAxis, double TuningFactor, int RotatingSpeed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/DoFastAngleTuningWithParam", ReplyAction="http://tempuri.org/ISystemService/DoFastAngleTuningWithParamResponse")]
        System.Threading.Tasks.Task<object> DoFastAngleTuningWithParamAsync(string Aligner, string LinearAxis, double LinearInterval, double LinearRange, int Speed, double Pitch, int AnalogCaptureChannel1, int AnalogCaptureChannel2, string RotatingAxis, double TuningFactor, int RotatingSpeed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoProfile1D", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoProfile1DResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoProfile1D(string Aligner, string Axis, double Interval, double Range, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoProfile1D", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoProfile1DResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoProfile1DAsync(string Aligner, string Axis, double Interval, double Range, int Speed);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoProfileND", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoProfileNDResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoProfileND(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoProfileND", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoProfileNDResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoProfileNDAsync(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoAngleTuning", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoAngleTuningResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_MoveMode))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOTypeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_IOStatusEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMUnitEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UserScript.Service.SSC_PMRangeEnum))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Bitmap))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Drawing.Image))]
        object @__SSC_DoAngleTuning(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_DoAngleTuning", ReplyAction="http://tempuri.org/ISystemService/__SSC_DoAngleTuningResponse")]
        System.Threading.Tasks.Task<object> @__SSC_DoAngleTuningAsync(string Profile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_SetUnit", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_SetUnitResponse")]
        void @__SSC_Powermeter_SetUnit(string Caption, UserScript.Service.SSC_PMUnitEnum Unit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_SetUnit", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_SetUnitResponse")]
        System.Threading.Tasks.Task @__SSC_Powermeter_SetUnitAsync(string Caption, UserScript.Service.SSC_PMUnitEnum Unit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_GetUnit", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_GetUnitResponse")]
        UserScript.Service.SSC_PMUnitEnum @__SSC_Powermeter_GetUnit(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_GetUnit", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_GetUnitResponse")]
        System.Threading.Tasks.Task<UserScript.Service.SSC_PMUnitEnum> @__SSC_Powermeter_GetUnitAsync(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_SetRange", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_SetRangeResponse")]
        void @__SSC_Powermeter_SetRange(string Caption, UserScript.Service.SSC_PMRangeEnum Range);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_SetRange", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_SetRangeResponse")]
        System.Threading.Tasks.Task @__SSC_Powermeter_SetRangeAsync(string Caption, UserScript.Service.SSC_PMRangeEnum Range);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_GetRange", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_GetRangeResponse")]
        UserScript.Service.SSC_PMRangeEnum @__SSC_Powermeter_GetRange(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_GetRange", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_GetRangeResponse")]
        System.Threading.Tasks.Task<UserScript.Service.SSC_PMRangeEnum> @__SSC_Powermeter_GetRangeAsync(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_ZeroOutput", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_ZeroOutputResponse")]
        void @__SSC_Powermeter_ZeroOutput(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_ZeroOutput", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_ZeroOutputResponse")]
        System.Threading.Tasks.Task @__SSC_Powermeter_ZeroOutputAsync(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_Read", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_ReadResponse")]
        double @__SSC_Powermeter_Read(string Caption);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemService/__SSC_Powermeter_Read", ReplyAction="http://tempuri.org/ISystemService/__SSC_Powermeter_ReadResponse")]
        System.Threading.Tasks.Task<double> @__SSC_Powermeter_ReadAsync(string Caption);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISystemServiceChannel : UserScript.Service.ISystemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemServiceClient : System.ServiceModel.ClientBase<UserScript.Service.ISystemService>, UserScript.Service.ISystemService {
        
        public SystemServiceClient() {
        }
        
        public SystemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SystemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void @__SSC_LogInfo(string Message) {
            base.Channel.@__SSC_LogInfo(Message);
        }
        
        public System.Threading.Tasks.Task @__SSC_LogInfoAsync(string Message) {
            return base.Channel.@__SSC_LogInfoAsync(Message);
        }
        
        public void @__SSC_LogError(string Message) {
            base.Channel.@__SSC_LogError(Message);
        }
        
        public System.Threading.Tasks.Task @__SSC_LogErrorAsync(string Message) {
            return base.Channel.@__SSC_LogErrorAsync(Message);
        }
        
        public void @__SSC_LogWarn(string Message) {
            base.Channel.@__SSC_LogWarn(Message);
        }
        
        public System.Threading.Tasks.Task @__SSC_LogWarnAsync(string Message) {
            return base.Channel.@__SSC_LogWarnAsync(Message);
        }
        
        public void @__SSC_Connect() {
            base.Channel.@__SSC_Connect();
        }
        
        public System.Threading.Tasks.Task @__SSC_ConnectAsync() {
            return base.Channel.@__SSC_ConnectAsync();
        }
        
        public void @__SSC_Disonnect() {
            base.Channel.@__SSC_Disonnect();
        }
        
        public System.Threading.Tasks.Task @__SSC_DisonnectAsync() {
            return base.Channel.@__SSC_DisonnectAsync();
        }
        
        public void @__SSC_SequenceStop() {
            base.Channel.@__SSC_SequenceStop();
        }
        
        public System.Threading.Tasks.Task @__SSC_SequenceStopAsync() {
            return base.Channel.@__SSC_SequenceStopAsync();
        }
        
        public double @__SSC_MeasurableDevice_Read(string Caption) {
            return base.Channel.@__SSC_MeasurableDevice_Read(Caption);
        }
        
        public System.Threading.Tasks.Task<double> @__SSC_MeasurableDevice_ReadAsync(string Caption) {
            return base.Channel.@__SSC_MeasurableDevice_ReadAsync(Caption);
        }
        
        public void @__SSC_MoveAxis(string Aligner, string Axis, UserScript.Service.SSC_MoveMode Mode, int Speed, double Distance) {
            base.Channel.@__SSC_MoveAxis(Aligner, Axis, Mode, Speed, Distance);
        }
        
        public System.Threading.Tasks.Task @__SSC_MoveAxisAsync(string Aligner, string Axis, UserScript.Service.SSC_MoveMode Mode, int Speed, double Distance) {
            return base.Channel.@__SSC_MoveAxisAsync(Aligner, Axis, Mode, Speed, Distance);
        }
        
        public void @__SSC_MoveToPresetPosition(string MotionComp, string Profile) {
            base.Channel.@__SSC_MoveToPresetPosition(MotionComp, Profile);
        }
        
        public System.Threading.Tasks.Task @__SSC_MoveToPresetPositionAsync(string MotionComp, string Profile) {
            return base.Channel.@__SSC_MoveToPresetPositionAsync(MotionComp, Profile);
        }
        
        public double @__SSC_GetAbsPosition(string Aligner, string Axis) {
            return base.Channel.@__SSC_GetAbsPosition(Aligner, Axis);
        }
        
        public System.Threading.Tasks.Task<double> @__SSC_GetAbsPositionAsync(string Aligner, string Axis) {
            return base.Channel.@__SSC_GetAbsPositionAsync(Aligner, Axis);
        }
        
        public void @__SSC_ShowImage(System.Drawing.Bitmap Image) {
            base.Channel.@__SSC_ShowImage(Image);
        }
        
        public System.Threading.Tasks.Task @__SSC_ShowImageAsync(System.Drawing.Bitmap Image) {
            return base.Channel.@__SSC_ShowImageAsync(Image);
        }
        
        public UserScript.Service.SSC_IOStatusEnum @__SSC_ReadIO(string IO, UserScript.Service.SSC_IOTypeEnum IOType) {
            return base.Channel.@__SSC_ReadIO(IO, IOType);
        }
        
        public System.Threading.Tasks.Task<UserScript.Service.SSC_IOStatusEnum> @__SSC_ReadIOAsync(string IO, UserScript.Service.SSC_IOTypeEnum IOType) {
            return base.Channel.@__SSC_ReadIOAsync(IO, IOType);
        }
        
        public void @__SSC_WriteIO(string IO, UserScript.Service.SSC_IOStatusEnum Status) {
            base.Channel.@__SSC_WriteIO(IO, Status);
        }
        
        public System.Threading.Tasks.Task @__SSC_WriteIOAsync(string IO, UserScript.Service.SSC_IOStatusEnum Status) {
            return base.Channel.@__SSC_WriteIOAsync(IO, Status);
        }
        
        public object @__SSC_DoBlindSearch(string Profile) {
            return base.Channel.@__SSC_DoBlindSearch(Profile);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoBlindSearchAsync(string Profile) {
            return base.Channel.@__SSC_DoBlindSearchAsync(Profile);
        }
        
        public object DoBlindSearchWithParam(string Aligner, string HorizontalAxis, string VerticalAxis, double Interval, double Range, int Speed, int AnalogCaptureChannel) {
            return base.Channel.DoBlindSearchWithParam(Aligner, HorizontalAxis, VerticalAxis, Interval, Range, Speed, AnalogCaptureChannel);
        }
        
        public System.Threading.Tasks.Task<object> DoBlindSearchWithParamAsync(string Aligner, string HorizontalAxis, string VerticalAxis, double Interval, double Range, int Speed, int AnalogCaptureChannel) {
            return base.Channel.DoBlindSearchWithParamAsync(Aligner, HorizontalAxis, VerticalAxis, Interval, Range, Speed, AnalogCaptureChannel);
        }
        
        public object @__SSC_DoFast1D(string Aligner, string Axis, double Interval, double Range, int Speed) {
            return base.Channel.@__SSC_DoFast1D(Aligner, Axis, Interval, Range, Speed);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoFast1DAsync(string Aligner, string Axis, double Interval, double Range, int Speed) {
            return base.Channel.@__SSC_DoFast1DAsync(Aligner, Axis, Interval, Range, Speed);
        }
        
        public object @__SSC_DoFastND(string Profile) {
            return base.Channel.@__SSC_DoFastND(Profile);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoFastNDAsync(string Profile) {
            return base.Channel.@__SSC_DoFastNDAsync(Profile);
        }
        
        public object @__SSC_DoFastAngleTuning(string Profile) {
            return base.Channel.@__SSC_DoFastAngleTuning(Profile);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoFastAngleTuningAsync(string Profile) {
            return base.Channel.@__SSC_DoFastAngleTuningAsync(Profile);
        }
        
        public object DoFastAngleTuningWithParam(string Aligner, string LinearAxis, double LinearInterval, double LinearRange, int Speed, double Pitch, int AnalogCaptureChannel1, int AnalogCaptureChannel2, string RotatingAxis, double TuningFactor, int RotatingSpeed) {
            return base.Channel.DoFastAngleTuningWithParam(Aligner, LinearAxis, LinearInterval, LinearRange, Speed, Pitch, AnalogCaptureChannel1, AnalogCaptureChannel2, RotatingAxis, TuningFactor, RotatingSpeed);
        }
        
        public System.Threading.Tasks.Task<object> DoFastAngleTuningWithParamAsync(string Aligner, string LinearAxis, double LinearInterval, double LinearRange, int Speed, double Pitch, int AnalogCaptureChannel1, int AnalogCaptureChannel2, string RotatingAxis, double TuningFactor, int RotatingSpeed) {
            return base.Channel.DoFastAngleTuningWithParamAsync(Aligner, LinearAxis, LinearInterval, LinearRange, Speed, Pitch, AnalogCaptureChannel1, AnalogCaptureChannel2, RotatingAxis, TuningFactor, RotatingSpeed);
        }
        
        public object @__SSC_DoProfile1D(string Aligner, string Axis, double Interval, double Range, int Speed) {
            return base.Channel.@__SSC_DoProfile1D(Aligner, Axis, Interval, Range, Speed);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoProfile1DAsync(string Aligner, string Axis, double Interval, double Range, int Speed) {
            return base.Channel.@__SSC_DoProfile1DAsync(Aligner, Axis, Interval, Range, Speed);
        }
        
        public object @__SSC_DoProfileND(string Profile) {
            return base.Channel.@__SSC_DoProfileND(Profile);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoProfileNDAsync(string Profile) {
            return base.Channel.@__SSC_DoProfileNDAsync(Profile);
        }
        
        public object @__SSC_DoAngleTuning(string Profile) {
            return base.Channel.@__SSC_DoAngleTuning(Profile);
        }
        
        public System.Threading.Tasks.Task<object> @__SSC_DoAngleTuningAsync(string Profile) {
            return base.Channel.@__SSC_DoAngleTuningAsync(Profile);
        }
        
        public void @__SSC_Powermeter_SetUnit(string Caption, UserScript.Service.SSC_PMUnitEnum Unit) {
            base.Channel.@__SSC_Powermeter_SetUnit(Caption, Unit);
        }
        
        public System.Threading.Tasks.Task @__SSC_Powermeter_SetUnitAsync(string Caption, UserScript.Service.SSC_PMUnitEnum Unit) {
            return base.Channel.@__SSC_Powermeter_SetUnitAsync(Caption, Unit);
        }
        
        public UserScript.Service.SSC_PMUnitEnum @__SSC_Powermeter_GetUnit(string Caption) {
            return base.Channel.@__SSC_Powermeter_GetUnit(Caption);
        }
        
        public System.Threading.Tasks.Task<UserScript.Service.SSC_PMUnitEnum> @__SSC_Powermeter_GetUnitAsync(string Caption) {
            return base.Channel.@__SSC_Powermeter_GetUnitAsync(Caption);
        }
        
        public void @__SSC_Powermeter_SetRange(string Caption, UserScript.Service.SSC_PMRangeEnum Range) {
            base.Channel.@__SSC_Powermeter_SetRange(Caption, Range);
        }
        
        public System.Threading.Tasks.Task @__SSC_Powermeter_SetRangeAsync(string Caption, UserScript.Service.SSC_PMRangeEnum Range) {
            return base.Channel.@__SSC_Powermeter_SetRangeAsync(Caption, Range);
        }
        
        public UserScript.Service.SSC_PMRangeEnum @__SSC_Powermeter_GetRange(string Caption) {
            return base.Channel.@__SSC_Powermeter_GetRange(Caption);
        }
        
        public System.Threading.Tasks.Task<UserScript.Service.SSC_PMRangeEnum> @__SSC_Powermeter_GetRangeAsync(string Caption) {
            return base.Channel.@__SSC_Powermeter_GetRangeAsync(Caption);
        }
        
        public void @__SSC_Powermeter_ZeroOutput(string Caption) {
            base.Channel.@__SSC_Powermeter_ZeroOutput(Caption);
        }
        
        public System.Threading.Tasks.Task @__SSC_Powermeter_ZeroOutputAsync(string Caption) {
            return base.Channel.@__SSC_Powermeter_ZeroOutputAsync(Caption);
        }
        
        public double @__SSC_Powermeter_Read(string Caption) {
            return base.Channel.@__SSC_Powermeter_Read(Caption);
        }
        
        public System.Threading.Tasks.Task<double> @__SSC_Powermeter_ReadAsync(string Caption) {
            return base.Channel.@__SSC_Powermeter_ReadAsync(Caption);
        }
    }
}
