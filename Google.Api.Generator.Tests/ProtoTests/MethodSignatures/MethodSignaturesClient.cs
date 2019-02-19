﻿using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using linq = System.Linq;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Testing.Methodsignatures
{
    public abstract class MethodSignaturesClient
    {
        public Response SimpleMethod(SimpleRequest request, gaxgrpc::CallSettings callSettings) => throw new sys::NotImplementedException();
        public stt::Task<Response> SimpleMethodAsync(SimpleRequest request, gaxgrpc::CallSettings callSettings) => throw new sys::NotImplementedException();

        // TEST_START
        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response SimpleMethod(int aNumber, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethod(new SimpleRequest { ANumber = aNumber, }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(int aNumber, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethodAsync(new SimpleRequest { ANumber = aNumber, }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(int aNumber, st::CancellationToken cancellationToken) =>
            SimpleMethodAsync(aNumber, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response SimpleMethod(string aString, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethod(new SimpleRequest
            {
                AString = aString ?? "",
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(string aString, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethodAsync(new SimpleRequest
            {
                AString = aString ?? "",
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(string aString, st::CancellationToken cancellationToken) =>
            SimpleMethodAsync(aString, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response SimpleMethod(int aNumber, string aString, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethod(new SimpleRequest
            {
                ANumber = aNumber,
                AString = aString ?? "",
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(int aNumber, string aString, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethodAsync(new SimpleRequest
            {
                ANumber = aNumber,
                AString = aString ?? "",
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(int aNumber, string aString, st::CancellationToken cancellationToken) =>
            SimpleMethodAsync(aNumber, aString, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response SimpleMethod(string aString, int aNumber, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethod(new SimpleRequest
            {
                AString = aString ?? "",
                ANumber = aNumber,
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(string aString, int aNumber, gaxgrpc::CallSettings callSettings = null) =>
            SimpleMethodAsync(new SimpleRequest
            {
                AString = aString ?? "",
                ANumber = aNumber,
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="aString">
        /// Another number with some test (preformatted) documetation
        /// that spans more than one line.
        /// </param>
        /// <param name="aNumber">
        /// A number with some test (preformatted) documentation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> SimpleMethodAsync(string aString, int aNumber, st::CancellationToken cancellationToken) =>
            SimpleMethodAsync(aString, aNumber, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        // TEST_END

        public virtual Response PrimitiveArgs(PrimitiveRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();
        public virtual stt::Task<Response> PrimitiveArgsAsync(PrimitiveRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();

        // TEST_START
        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response PrimitiveArgs(int optional, int required, scg::IEnumerable<int> repeatedOptional, scg::IEnumerable<int> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            PrimitiveArgs(new PrimitiveRequest
            {
                Optional = optional,
                Required = required,
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<int>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> PrimitiveArgsAsync(int optional, int required, scg::IEnumerable<int> repeatedOptional, scg::IEnumerable<int> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            PrimitiveArgsAsync(new PrimitiveRequest
            {
                Optional = optional,
                Required = required,
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<int>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> PrimitiveArgsAsync(int optional, int required, scg::IEnumerable<int> repeatedOptional, scg::IEnumerable<int> repeatedRequired, st::CancellationToken cancellationToken) =>
            PrimitiveArgsAsync(optional, required, repeatedOptional, repeatedRequired, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        // TEST_END

        public virtual Response StringArgs(StringRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();
        public virtual stt::Task<Response> StringArgsAsync(StringRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();

        // TEST_START
        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response StringArgs(string optional, string required, scg::IEnumerable<string> repeatedOptional, scg::IEnumerable<string> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            StringArgs(new StringRequest
            {
                Optional = optional ?? "",
                Required = gax::GaxPreconditions.CheckNotNullOrEmpty(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<string>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> StringArgsAsync(string optional, string required, scg::IEnumerable<string> repeatedOptional, scg::IEnumerable<string> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            StringArgsAsync(new StringRequest
            {
                Optional = optional ?? "",
                Required = gax::GaxPreconditions.CheckNotNullOrEmpty(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<string>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> StringArgsAsync(string optional, string required, scg::IEnumerable<string> repeatedOptional, scg::IEnumerable<string> repeatedRequired, st::CancellationToken cancellationToken) =>
            StringArgsAsync(optional, required, repeatedOptional, repeatedRequired, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        // TEST_END

        public virtual Response BytesArgs(BytesRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();
        public virtual stt::Task<Response> BytesArgsAsync(BytesRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();

        // TEST_START
        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response BytesArgs(proto::ByteString optional, proto::ByteString required, scg::IEnumerable<proto::ByteString> repeatedOptional, scg::IEnumerable<proto::ByteString> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            BytesArgs(new BytesRequest
            {
                Optional = optional ?? proto::ByteString.Empty,
                Required = gax::GaxPreconditions.CheckNotNull(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<proto::ByteString>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> BytesArgsAsync(proto::ByteString optional, proto::ByteString required, scg::IEnumerable<proto::ByteString> repeatedOptional, scg::IEnumerable<proto::ByteString> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            BytesArgsAsync(new BytesRequest
            {
                Optional = optional ?? proto::ByteString.Empty,
                Required = gax::GaxPreconditions.CheckNotNull(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<proto::ByteString>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> BytesArgsAsync(proto::ByteString optional, proto::ByteString required, scg::IEnumerable<proto::ByteString> repeatedOptional, scg::IEnumerable<proto::ByteString> repeatedRequired, st::CancellationToken cancellationToken) =>
            BytesArgsAsync(optional, required, repeatedOptional, repeatedRequired, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        // TEST_END

        public virtual Response MessageArgs(MessageRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();
        public virtual stt::Task<Response> MessageArgsAsync(MessageRequest request, gaxgrpc::CallSettings callSettings = null) => throw new sys::NotImplementedException();

        // TEST_START
        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Response MessageArgs(MessageRequest.Types.Msg optional, MessageRequest.Types.Msg required, scg::IEnumerable<MessageRequest.Types.Msg> repeatedOptional, scg::IEnumerable<MessageRequest.Types.Msg> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            MessageArgs(new MessageRequest
            {
                Optional = optional,
                Required = gax::GaxPreconditions.CheckNotNull(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<MessageRequest.Types.Msg>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> MessageArgsAsync(MessageRequest.Types.Msg optional, MessageRequest.Types.Msg required, scg::IEnumerable<MessageRequest.Types.Msg> repeatedOptional, scg::IEnumerable<MessageRequest.Types.Msg> repeatedRequired, gaxgrpc::CallSettings callSettings = null) =>
            MessageArgsAsync(new MessageRequest
            {
                Optional = optional,
                Required = gax::GaxPreconditions.CheckNotNull(required, nameof(required)),
                RepeatedOptional =
                {
                    repeatedOptional ?? linq::Enumerable.Empty<MessageRequest.Types.Msg>(),
                },
                RepeatedRequired =
                {
                    gax::GaxPreconditions.CheckNotNull(repeatedRequired, nameof(repeatedRequired)),
                },
            }, callSettings);

        /// <summary>
        /// </summary>
        /// <param name="optional">
        /// </param>
        /// <param name="required">
        /// </param>
        /// <param name="repeatedOptional">
        /// </param>
        /// <param name="repeatedRequired">
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Response> MessageArgsAsync(MessageRequest.Types.Msg optional, MessageRequest.Types.Msg required, scg::IEnumerable<MessageRequest.Types.Msg> repeatedOptional, scg::IEnumerable<MessageRequest.Types.Msg> repeatedRequired, st::CancellationToken cancellationToken) =>
            MessageArgsAsync(optional, required, repeatedOptional, repeatedRequired, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
        // TEST_END
    }
}
