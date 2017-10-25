using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/BaseNCodec", DoNotGenerateAcw=true)]
	public abstract partial class BaseNCodec : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='MASK_8BITS']"
		[Register ("MASK_8BITS")]
		protected const int Mask8bits = (int) 255;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='MIME_CHUNK_SIZE']"
		[Register ("MIME_CHUNK_SIZE")]
		public const int MimeChunkSize = (int) 76;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='PAD']"
		[Register ("PAD")]
		protected const sbyte Pad = (sbyte) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='PAD_DEFAULT']"
		[Register ("PAD_DEFAULT")]
		protected const sbyte PadDefault = (sbyte) 61;

		static IntPtr mBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mBuffer']"
		[Register ("mBuffer")]
		protected IList<byte> MBuffer {
			get {
				if (mBuffer_jfieldId == IntPtr.Zero)
					mBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mBuffer", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBuffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBuffer_jfieldId == IntPtr.Zero)
					mBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mBuffer", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCurrentLinePos_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mCurrentLinePos']"
		[Register ("mCurrentLinePos")]
		protected int MCurrentLinePos {
			get {
				if (mCurrentLinePos_jfieldId == IntPtr.Zero)
					mCurrentLinePos_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentLinePos", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCurrentLinePos_jfieldId);
			}
			set {
				if (mCurrentLinePos_jfieldId == IntPtr.Zero)
					mCurrentLinePos_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentLinePos", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentLinePos_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mEof_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mEof']"
		[Register ("mEof")]
		protected bool MEof {
			get {
				if (mEof_jfieldId == IntPtr.Zero)
					mEof_jfieldId = JNIEnv.GetFieldID (class_ref, "mEof", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mEof_jfieldId);
			}
			set {
				if (mEof_jfieldId == IntPtr.Zero)
					mEof_jfieldId = JNIEnv.GetFieldID (class_ref, "mEof", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEof_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLineLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mLineLength']"
		[Register ("mLineLength")]
		protected int MLineLength {
			get {
				if (mLineLength_jfieldId == IntPtr.Zero)
					mLineLength_jfieldId = JNIEnv.GetFieldID (class_ref, "mLineLength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mLineLength_jfieldId);
			}
			set {
				if (mLineLength_jfieldId == IntPtr.Zero)
					mLineLength_jfieldId = JNIEnv.GetFieldID (class_ref, "mLineLength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLineLength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mModulus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mModulus']"
		[Register ("mModulus")]
		protected int MModulus {
			get {
				if (mModulus_jfieldId == IntPtr.Zero)
					mModulus_jfieldId = JNIEnv.GetFieldID (class_ref, "mModulus", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mModulus_jfieldId);
			}
			set {
				if (mModulus_jfieldId == IntPtr.Zero)
					mModulus_jfieldId = JNIEnv.GetFieldID (class_ref, "mModulus", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mModulus_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPos_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/field[@name='mPos']"
		[Register ("mPos")]
		protected int MPos {
			get {
				if (mPos_jfieldId == IntPtr.Zero)
					mPos_jfieldId = JNIEnv.GetFieldID (class_ref, "mPos", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mPos_jfieldId);
			}
			set {
				if (mPos_jfieldId == IntPtr.Zero)
					mPos_jfieldId = JNIEnv.GetFieldID (class_ref, "mPos", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPos_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/BaseNCodec", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodec); }
		}

		protected BaseNCodec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/constructor[@name='BaseNCodec' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		protected unsafe BaseNCodec (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (BaseNCodec)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_getDefaultBufferSize;
#pragma warning disable 0169
		static Delegate GetGetDefaultBufferSizeHandler ()
		{
			if (cb_getDefaultBufferSize == null)
				cb_getDefaultBufferSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultBufferSize);
			return cb_getDefaultBufferSize;
		}

		static int n_GetDefaultBufferSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultBufferSize;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultBufferSize;
		protected virtual unsafe int DefaultBufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='getDefaultBufferSize' and count(parameter)=0]"
			[Register ("getDefaultBufferSize", "()I", "GetGetDefaultBufferSizeHandler")]
			get {
				if (id_getDefaultBufferSize == IntPtr.Zero)
					id_getDefaultBufferSize = JNIEnv.GetMethodID (class_ref, "getDefaultBufferSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultBufferSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultBufferSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_containsAlphabetOrPad_arrayB;
#pragma warning disable 0169
		static Delegate GetContainsAlphabetOrPad_arrayBHandler ()
		{
			if (cb_containsAlphabetOrPad_arrayB == null)
				cb_containsAlphabetOrPad_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAlphabetOrPad_arrayB);
			return cb_containsAlphabetOrPad_arrayB;
		}

		static bool n_ContainsAlphabetOrPad_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ContainsAlphabetOrPad (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsAlphabetOrPad_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='containsAlphabetOrPad' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("containsAlphabetOrPad", "([B)Z", "GetContainsAlphabetOrPad_arrayBHandler")]
		protected virtual unsafe bool ContainsAlphabetOrPad (byte[] p0)
		{
			if (id_containsAlphabetOrPad_arrayB == IntPtr.Zero)
				id_containsAlphabetOrPad_arrayB = JNIEnv.GetMethodID (class_ref, "containsAlphabetOrPad", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsAlphabetOrPad_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsAlphabetOrPad", "([B)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static IntPtr n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "GetDecode_arrayBHandler")]
		public virtual unsafe byte[] Decode (byte[] p0)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_Object_Handler ()
		{
			if (cb_decode_Ljava_lang_Object_ == null)
				cb_decode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_Object_);
			return cb_decode_Ljava_lang_Object_;
		}

		static IntPtr n_Decode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("decode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetDecode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object p0)
		{
			if (id_decode_Ljava_lang_Object_ == IntPtr.Zero)
				id_decode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_decode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_lang_String_Handler ()
		{
			if (cb_decode_Ljava_lang_String_ == null)
				cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_);
			return cb_decode_Ljava_lang_String_;
		}

		static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decode", "(Ljava/lang/String;)[B", "GetDecode_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] Decode (string p0)
		{
			if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
				id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_encode_arrayB;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBHandler ()
		{
			if (cb_encode_arrayB == null)
				cb_encode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayB);
			return cb_encode_arrayB;
		}

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "GetEncode_arrayBHandler")]
		public virtual unsafe byte[] Encode (byte[] p0)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encode_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_lang_Object_Handler ()
		{
			if (cb_encode_Ljava_lang_Object_ == null)
				cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_lang_Object_);
			return cb_encode_Ljava_lang_Object_;
		}

		static IntPtr n_Encode_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("encode", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetEncode_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Encode (global::Java.Lang.Object p0)
		{
			if (id_encode_Ljava_lang_Object_ == IntPtr.Zero)
				id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_encodeAsString_arrayB;
#pragma warning disable 0169
		static Delegate GetEncodeAsString_arrayBHandler ()
		{
			if (cb_encodeAsString_arrayB == null)
				cb_encodeAsString_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeAsString_arrayB);
			return cb_encodeAsString_arrayB;
		}

		static IntPtr n_EncodeAsString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.EncodeAsString (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeAsString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='encodeAsString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeAsString", "([B)Ljava/lang/String;", "GetEncodeAsString_arrayBHandler")]
		public virtual unsafe string EncodeAsString (byte[] p0)
		{
			if (id_encodeAsString_arrayB == IntPtr.Zero)
				id_encodeAsString_arrayB = JNIEnv.GetMethodID (class_ref, "encodeAsString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeAsString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeAsString", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_encodeToString_arrayB;
#pragma warning disable 0169
		static Delegate GetEncodeToString_arrayBHandler ()
		{
			if (cb_encodeToString_arrayB == null)
				cb_encodeToString_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeToString_arrayB);
			return cb_encodeToString_arrayB;
		}

		static IntPtr n_EncodeToString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.EncodeToString (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeToString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='encodeToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeToString", "([B)Ljava/lang/String;", "GetEncodeToString_arrayBHandler")]
		public virtual unsafe string EncodeToString (byte[] p0)
		{
			if (id_encodeToString_arrayB == IntPtr.Zero)
				id_encodeToString_arrayB = JNIEnv.GetMethodID (class_ref, "encodeToString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeToString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeToString", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_ensureBufferSize_I;
#pragma warning disable 0169
		static Delegate GetEnsureBufferSize_IHandler ()
		{
			if (cb_ensureBufferSize_I == null)
				cb_ensureBufferSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnsureBufferSize_I);
			return cb_ensureBufferSize_I;
		}

		static void n_EnsureBufferSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsureBufferSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ensureBufferSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='ensureBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ensureBufferSize", "(I)V", "GetEnsureBufferSize_IHandler")]
		protected virtual unsafe void EnsureBufferSize (int p0)
		{
			if (id_ensureBufferSize_I == IntPtr.Zero)
				id_ensureBufferSize_I = JNIEnv.GetMethodID (class_ref, "ensureBufferSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ensureBufferSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ensureBufferSize", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getEncodedLength_arrayB;
#pragma warning disable 0169
		static Delegate GetGetEncodedLength_arrayBHandler ()
		{
			if (cb_getEncodedLength_arrayB == null)
				cb_getEncodedLength_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetEncodedLength_arrayB);
			return cb_getEncodedLength_arrayB;
		}

		static long n_GetEncodedLength_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long __ret = __this.GetEncodedLength (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedLength_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='getEncodedLength' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getEncodedLength", "([B)J", "GetGetEncodedLength_arrayBHandler")]
		public virtual unsafe long GetEncodedLength (byte[] p0)
		{
			if (id_getEncodedLength_arrayB == IntPtr.Zero)
				id_getEncodedLength_arrayB = JNIEnv.GetMethodID (class_ref, "getEncodedLength", "([B)J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedLength_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedLength", "([B)J"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_isInAlphabet_B;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_BHandler ()
		{
			if (cb_isInAlphabet_B == null)
				cb_isInAlphabet_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_IsInAlphabet_B);
			return cb_isInAlphabet_B;
		}

		static bool n_IsInAlphabet_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInAlphabet (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected abstract bool IsInAlphabet (sbyte p0);

		static Delegate cb_isInAlphabet_arrayBZ;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_arrayBZHandler ()
		{
			if (cb_isInAlphabet_arrayBZ == null)
				cb_isInAlphabet_arrayBZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_IsInAlphabet_arrayBZ);
			return cb_isInAlphabet_arrayBZ;
		}

		static bool n_IsInAlphabet_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.IsInAlphabet (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("isInAlphabet", "([BZ)Z", "GetIsInAlphabet_arrayBZHandler")]
		public virtual unsafe bool IsInAlphabet (byte[] p0, bool p1)
		{
			if (id_isInAlphabet_arrayBZ == IntPtr.Zero)
				id_isInAlphabet_arrayBZ = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "([BZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_arrayBZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "([BZ)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_isInAlphabet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_Ljava_lang_String_Handler ()
		{
			if (cb_isInAlphabet_Ljava_lang_String_ == null)
				cb_isInAlphabet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsInAlphabet_Ljava_lang_String_);
			return cb_isInAlphabet_Ljava_lang_String_;
		}

		static bool n_IsInAlphabet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.BaseNCodec __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.BaseNCodec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInAlphabet (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isInAlphabet", "(Ljava/lang/String;)Z", "GetIsInAlphabet_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsInAlphabet (string p0)
		{
			if (id_isInAlphabet_Ljava_lang_String_ == IntPtr.Zero)
				id_isInAlphabet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isWhiteSpace_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='isWhiteSpace' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isWhiteSpace", "(B)Z", "")]
		protected static unsafe bool IsWhiteSpace (sbyte p0)
		{
			if (id_isWhiteSpace_B == IntPtr.Zero)
				id_isWhiteSpace_B = JNIEnv.GetStaticMethodID (class_ref, "isWhiteSpace", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWhiteSpace_B, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/BaseNCodec", DoNotGenerateAcw=true)]
	internal partial class BaseNCodecInvoker : BaseNCodec {

		public BaseNCodecInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNCodecInvoker); }
		}

		static IntPtr id_isInAlphabet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='BaseNCodec']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected override unsafe bool IsInAlphabet (sbyte p0)
		{
			if (id_isInAlphabet_B == IntPtr.Zero)
				id_isInAlphabet_B = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_B, __args);
			} finally {
			}
		}

	}

}
