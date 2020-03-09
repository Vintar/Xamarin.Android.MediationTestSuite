using System;
using Android.Runtime;
using GoogleGson;
using Java.Interop;
using Java.Lang.Reflect;

namespace Com.Google.Android.Ads.Mediationtestsuite.Utils
{
	public partial class CLDResponseDeserializer
	{
		unsafe Java.Lang.Object IJsonDeserializer.Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
        {
			const string __id = "deserialize.(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Lcom/google/android/ads/mediationtestsuite/dataobjects/CLDResponse;";
			
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];

				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				__args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
				__args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);

				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Ads.Mediationtestsuite.Dataobjects.CLDResponse>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

	public partial class AdFormatSerializer
	{
		unsafe Java.Lang.Object IJsonDeserializer.Deserialize(JsonElement p0, IType p1, IJsonDeserializationContext p2)
		{
			const string __id = "deserialize.(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Lcom/google/android/ads/mediationtestsuite/dataobjects/AdFormat;";
			
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				__args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
				__args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);

				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Ads.Mediationtestsuite.Dataobjects.AdFormat>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		public unsafe JsonElement Serialize(Java.Lang.Object p0, IType p1, IJsonSerializationContext p2)
		{
			const string __id = "serialize.(Lcom/google/android/ads/mediationtestsuite/dataobjects/AdFormat;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;";
			
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				__args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
				__args[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);

				return global::Java.Lang.Object.GetObject<global::GoogleGson.JsonElement>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
}