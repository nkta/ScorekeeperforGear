S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170403.0854
Build-Date: 2017.04.03 08:54:58

Crash Information
Process Name: scorekeeperforgear
PID: 6061
Date: 2017-06-19 07:06:40+0900
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x46

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb3db9294, esi = 0x00000000
ebp = 0xbfe442c8, esp = 0xbfe43674
eax = 0xffffffff, ebx = 0xb75e2ff4
ecx = 0x00000000, edx = 0xb75e4430
eip = 0xb74c3ec2

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         5 KB
Cached:     131568 KB
VmPeak:      63252 KB
VmSize:      63252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        6976 KB
VmRSS:        6976 KB
VmData:       2228 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32640 KB
VmPTE:          52 KB
VmSwap:          0 KB

Maps Information
b3b69000 b3b6c000 r-xp /usr/lib/libdri2.so.0.0.0
b3b6d000 b3b78000 r-xp /usr/lib/libdrm.so.2.4.0
b3b79000 b3b82000 r-xp /usr/lib/libtbm.so.1.0.0
b3b83000 b3b8a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3b8b000 b3b94000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3b95000 b3b9c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3b9d000 b3ba5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3ba6000 b3baa000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3bab000 b3bc8000 r-xp /usr/lib/libtts.so
b3bc9000 b3bdf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
b3be0000 b3d24000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d28000 b3d40000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d41000 b3d47000 r-xp /usr/lib/libctx-client.so.0.8.3
b3d48000 b3d52000 r-xp /usr/lib/libctx-shared.so.0.8.3
b3d53000 b3d65000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d66000 b3d89000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d8a000 b3d9a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3d9b000 b3dac000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b3dae000 b3dbc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
b3dbe000 b3dc9000 r-xp /lib/libnss_files-2.13.so
b3fcb000 b3ff2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3ff3000 b4018000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4019000 b413a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b414a000 b417f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4181000 b4184000 r-xp /usr/lib/libiniparser.so.0
b4186000 b4190000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4191000 b419a000 r-xp /usr/lib/libappsvc.so.0.1.0
b419b000 b419e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b419f000 b41a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b41a6000 b41ad000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b41ae000 b41b4000 r-xp /usr/lib/libogg.so.0.7.1
b41b5000 b41e0000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e1000 b42cc000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42da000 b42dc000 r-xp /usr/lib/libXau.so.6.0.0
b42dd000 b4336000 r-xp /usr/lib/libssl.so.1.0.0
b433b000 b436c000 r-xp /usr/lib/libidn.so.11.5.44
b436d000 b437d000 r-xp /usr/lib/libcares.so.2.1.0
b437e000 b43e7000 r-xp /usr/lib/libsndfile.so.1.0.25
b43ed000 b43f9000 r-xp /usr/lib/libsensord-shared.so
b43fa000 b4420000 r-xp /lib/libexpat.so.1.5.2
b4422000 b4449000 r-xp /usr/lib/libpng12.so.0.50.0
b444a000 b446a000 r-xp /usr/lib/libxcb.so.1.1.0
b446b000 b44da000 r-xp /usr/lib/libcurl.so.4.3.0
b44dc000 b44e7000 r-xp /usr/lib/libethumb.so.1.7.99
b5d64000 b5e3c000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e48000 b5e4b000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e4c000 b5e62000 r-xp /usr/lib/libremix.so.0.0.0
b5e63000 b5e65000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e66000 b5e92000 r-xp /usr/lib/liblua-5.1.so
b5e93000 b5e9d000 r-xp /usr/lib/libembryo.so.1.7.99
b5e9e000 b5ee4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ef5000 b5f24000 r-xp /usr/lib/libsensor.so.1.9.0
b5f25000 b5fa7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fac000 b5fe0000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5fe2000 b603d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b603f000 b6055000 r-xp /usr/lib/libfribidi.so.0.3.1
b6056000 b60e2000 r-xp /usr/lib/libfreetype.so.6.11.3
b60e6000 b60e9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60ea000 b60f0000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60f1000 b60f7000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60f9000 b610a000 r-xp /usr/lib/libXext.so.6.4.0
b610b000 b623f000 r-xp /usr/lib/libX11.so.6.3.0
b6243000 b6248000 r-xp /usr/lib/libXtst.so.6.1.0
b6249000 b6251000 r-xp /usr/lib/libXrender.so.1.3.0
b6252000 b625b000 r-xp /usr/lib/libXrandr.so.2.2.0
b625c000 b625e000 r-xp /usr/lib/libXinerama.so.1.0.0
b625f000 b626d000 r-xp /usr/lib/libXi.so.6.1.0
b626e000 b6272000 r-xp /usr/lib/libXfixes.so.3.1.0
b6273000 b6275000 r-xp /usr/lib/libXgesture.so.7.0.0
b6276000 b6278000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6279000 b627b000 r-xp /usr/lib/libXdamage.so.1.1.0
b627c000 b6285000 r-xp /usr/lib/libXcursor.so.1.0.2
b6286000 b62b1000 r-xp /usr/lib/libecore_con.so.1.7.99
b62b3000 b62bb000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62bc000 b62c7000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62c8000 b62ce000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b62cf000 b62f0000 r-xp /usr/lib/libefreet.so.1.7.99
b62f2000 b62fe000 r-xp /usr/lib/libedbus.so.1.7.99
b62ff000 b648e000 r-xp /usr/lib/libicuuc.so.57.1
b649d000 b6719000 r-xp /usr/lib/libicui18n.so.57.1
b6722000 b67c0000 r-xp /usr/lib/libedje.so.1.7.99
b67c2000 b67d3000 r-xp /usr/lib/libecore_input.so.1.7.99
b67d4000 b67db000 r-xp /usr/lib/libecore_file.so.1.7.99
b67dc000 b6802000 r-xp /usr/lib/libeet.so.1.7.99
b680b000 b6935000 r-xp /usr/lib/libevas.so.1.7.99
b6953000 b6987000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6989000 b69cd000 r-xp /usr/lib/libecore_x.so.1.7.99
b69cf000 b6bca000 r-xp /usr/lib/libelementary.so.1.7.99
b6bd9000 b6bdb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6bdc000 b6be2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6be3000 b6be7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bec000 b6bed000 r-xp /usr/lib/libjournal.so.0.1.0
b6bee000 b6d36000 r-xp /usr/lib/libxml2.so.2.7.8
b6d3c000 b6d4f000 r-xp /lib/libresolv-2.13.so
b6d53000 b6d70000 r-xp /lib/libz.so.1.2.5
b6d71000 b6d74000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d76000 b6d7b000 r-xp /usr/lib/libffi.so.5.0.10
b6d7c000 b6d7d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d7e000 b6d82000 r-xp /lib/libattr.so.1.1.0
b6d83000 b6f96000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fb1000 b6fd2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fd4000 b6ffc000 r-xp /lib/libm-2.13.so
b6ffe000 b7059000 r-xp /usr/lib/libeina.so.1.7.99
b705b000 b7066000 r-xp /usr/lib/libvconf.so.0.2.45
b7067000 b706a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b706b000 b70b9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70bb000 b721c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7220000 b7227000 r-xp /lib/librt-2.13.so
b7229000 b7230000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b7232000 b724c000 r-xp /lib/libgcc_s-4.6.4.so.1
b724d000 b7255000 r-xp /lib/libcrypt-2.13.so
b727f000 b7283000 r-xp /lib/libcap.so.2.21
b7284000 b7286000 r-xp /usr/lib/libiri.so
b7287000 b72b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72b4000 b72d4000 r-xp /usr/lib/libecore.so.1.7.99
b72e3000 b72ec000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72ed000 b7410000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7412000 b7425000 r-xp /usr/lib/libail.so.0.1.0
b7426000 b744b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b744c000 b7456000 r-xp /lib/libunwind.so.8.0.1
b7460000 b75e0000 r-xp /lib/libc-2.13.so
b75e7000 b7631000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7633000 b7638000 r-xp /usr/lib/libbundle.so.0.1.22
b7639000 b763c000 r-xp /lib/libdl-2.13.so
b763e000 b7655000 r-xp /lib/libpthread-2.13.so
b7659000 b765c000 r-xp /usr/lib/libdlog.so.0.0.0
b765d000 b765f000 r-xp /usr/lib/libttrace.so.1.1
b7660000 b7665000 r-xp /usr/lib/libsmack.so.1.0.0
b7666000 b770e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7711000 b772b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b772c000 b773c000 r-xp /usr/lib/libaul.so.0.1.0
b773f000 b7745000 r-xp /usr/lib/libappcore-common.so.1.1
b7746000 b774b000 r-xp /usr/lib/libappcore-efl.so.1.1
b774d000 b7752000 r-xp /usr/lib/libsys-assert.so
b7755000 b7756000 r-xp [vdso]
b7756000 b7774000 r-xp /lib/ld-2.13.so
b7776000 b777d000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:6061)
Call Stack Count: 2
 0: fclose + 0x22 (0xb74c3ec2) [/lib/libc.so.6] + 0x63ec2
 1: __libc_start_main + 0xf3 (0xb74791a3) [/lib/libc.so.6] + 0x191a3
End of Call Stack

Package Information
Package Name: org.example.scorekeeperforgear
Package ID : org.example.scorekeeperforgear
Version: 1.0.0
Package Type: rpm
App Name: scorekeeperforgear
App ID: org.example.scorekeeperforgear
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
egin
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 1
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 17 1
06-19 07:06:37.877+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2417): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/DATA_PROVIDER_MASTER( 2417): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.scorekeeperforgear] 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2416): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/ADD_VIEWER( 2376): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.scorekeeperforgear] 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/W_HOME  ( 2376): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:install_percent val:60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/APPS    ( 2376): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.scorekeeperforgear
06-19 07:06:37.877+0900 D/APPS    ( 2376): pkgmgr.c: _install_percent(469) >  package(org.example.scorekeeperforgear) with 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 07:06:37.877+0900 D/PKGMGR  ( 2521): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 07:06:37.877+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:37.877+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:37.877+0900 E/PKGMGR_CERT( 6001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
06-19 07:06:37.877+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/lib]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_make_directory(1601) > mkdir failed. appdir=[/usr/apps/org.example.scorekeeperforgear/shared], errno=[2][No such file or directory]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/shared]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/shared/res]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/tizen-manifest.xml]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/author-signature.xml]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/signature1.xml]
06-19 07:06:37.887+0900 E/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/share/packages/org.example.scorekeeperforgear.xml]
06-19 07:06:37.887+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1405) > Exist shared/data folder (path:[/opt/usr/apps/org.example.scorekeeperforgear/shared/data])
06-19 07:06:37.897+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.897+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear, 5, _), result=[0]
06-19 07:06:37.897+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared, 5, _), result=[0]
06-19 07:06:37.897+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/res, 5, _), result=[0]
06-19 07:06:37.907+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/data, 2), result=[0]
06-19 07:06:37.907+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_get_group_id(1881) > encoding done, len=[28]
06-19 07:06:37.907+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_apply_smack(1989) > groupid = [YE519RlTq5KnqeX1161u+Id8Hi8=] for shared/trusted.
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/trusted, 1, YE519RlTq5KnqeX1161u+Id8Hi8=), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/bin, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/data, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/res, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/cache, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/tizen-manifest.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/author-signature.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/signature1.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/share/packages/org.example.scorekeeperforgear.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear, 5, _), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/data, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/cache, 0, org.example.scorekeeperforgear), result=[0]
06-19 07:06:37.917+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/shared, 5, _), result=[0]
06-19 07:06:37.927+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/shared/data, 2), result=[0]
06-19 07:06:37.937+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.scorekeeperforgear] version set to [2.3.2] result=[0]
06-19 07:06:37.937+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_package_install(2345) > api-version fot privilege has done successfully.
06-19 07:06:37.937+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/display]
06-19 07:06:37.937+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:37.937+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:37.947+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:37.947+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 07:06:37.947+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/haptic]
06-19 07:06:37.957+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:37.957+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:37.967+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:37.967+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 07:06:37.967+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/healthinfo]
06-19 07:06:37.967+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:37.977+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:37.977+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:37.977+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 07:06:37.977+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/mediastorage]
06-19 07:06:37.977+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:37.987+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:37.987+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:37.987+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 07:06:37.987+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/power]
06-19 07:06:37.987+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:37.997+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:37.997+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:37.997+0900 D/rpm-installer( 6001): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 07:06:38.007+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:38.007+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:38.007+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_package_install(2355) > permission applying done successfully.
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/display
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/haptic
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/healthinfo
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/power
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 07:06:38.007+0900 D/PRIVILEGE_MANAGER( 6001): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_verify_privilege_list(752) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_package_install(2363) > _coretpk_installer_verify_privilege_list done.
06-19 07:06:38.007+0900 D/rpm-installer( 6001): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.scorekeeperforgear], key=[install_percent], val=[100]
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_package_install(2385) > install status is [2].
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_package_install(2397) > _coretpk_installer_package_install is done.
06-19 07:06:38.007+0900 D/rpm-installer( 6001): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.scorekeeperforgear], key=[end], val=[ok]
06-19 07:06:38.007+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2964) > success
06-19 07:06:38.007+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.007+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.007+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.007+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.007+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.007+0900 D/PKGMGR  ( 2521): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.007+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.007+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.007+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.007+0900 D/PKGMGR  ( 2417): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.007+0900 D/DATA_PROVIDER_MASTER( 2417): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.scorekeeperforgear] 100
06-19 07:06:38.007+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.007+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.017+0900 D/ADD_VIEWER( 2376): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.scorekeeperforgear] 100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.017+0900 D/W_HOME  ( 2376): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:install_percent val:100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.scorekeeperforgear
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _install_percent(469) >  package(org.example.scorekeeperforgear) with 100
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2375): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2375): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2416): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2417): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/DATA_PROVIDER_MASTER( 2417): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.scorekeeperforgear] ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2417): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2307): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2307): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/AUL_AMD ( 2307): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.scorekeeperforgear), key(end), value(ok)
06-19 07:06:38.017+0900 D/AUL_AMD ( 2307): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
06-19 07:06:38.017+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2521): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2521): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2251): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2251): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/ADD_VIEWER( 2376): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.scorekeeperforgear] ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/W_HOME  ( 2376): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:end val:ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 07:06:38.017+0900 D/PKGMGR  ( 2376): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_997851777] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.scorekeeperforgear
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _end(651) >  Package(org.example.scorekeeperforgear) : key(update) - val(ok)
06-19 07:06:38.017+0900 D/AUL_AMD ( 2307): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
06-19 07:06:38.017+0900 D/AUL_AMD ( 2307): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.scorekeeperforgear, comp:ui, type:rpm
06-19 07:06:38.017+0900 D/PKGMGR  ( 2307): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2307): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.scorekeeperforgear]
06-19 07:06:38.017+0900 D/APPS    ( 2376): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.scorekeeperforgear]'s item object
06-19 07:06:38.017+0900 D/APPS    ( 2376): db.c: apps_db_remove_item(404) >  Remove the item[org.example.scorekeeperforgear]
06-19 07:06:38.017+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 07:06:38.017+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 07:06:38.017+0900 E/PKGMGR_INFO( 2251): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-19 07:06:38.017+0900 D/PKGMGR  ( 2251): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.017+0900 D/PKGMGR  ( 2251): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:38.017+0900 D/APPS    ( 2376): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 07:06:38.017+0900 D/APPS    ( 2376): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 07:06:38.017+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
06-19 07:06:38.017+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 07:06:38.017+0900 D/DATA_PROVIDER_MASTER( 2417): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 07:06:38.017+0900 D/BADGE   ( 2417): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 07:06:38.017+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 07:06:38.017+0900 E/DATA_PROVIDER_MASTER( 2417): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 07:06:38.017+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2417, fd: -1
06-19 07:06:38.017+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2417), fd: -1
06-19 07:06:38.027+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 34 (recv_fd: -1)
06-19 07:06:38.027+0900 D/APPS    ( 2376): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 07:06:38.027+0900 D/COM_CORE( 2417): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb957a040 is terminated (NIL packet)
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 07:06:38.027+0900 D/BADGE   ( 2417): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 07:06:38.027+0900 E/DATA_PROVIDER_MASTER( 2417): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 07:06:38.027+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2417, fd: -1
06-19 07:06:38.027+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2417), fd: -1
06-19 07:06:38.027+0900 D/COM_CORE( 2376): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 34 (recv_fd: -1)
06-19 07:06:38.027+0900 D/COM_CORE( 2417): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 07:06:38.027+0900 D/APPS    ( 2376): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 07:06:38.027+0900 D/rpm-installer( 6001): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 07:06:38.027+0900 D/rpm-installer( 6001): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2974) > _ri_privilege_enable_permissions(privilege/appdebugging succeeded for debug_mode.
06-19 07:06:38.027+0900 D/rpm-installer( 6001): rpm-appcore-intf.c: main(225) > sync() start
06-19 07:06:38.027+0900 D/APPS    ( 2376): item.c: item_create(819) >  Icon size after ea_effect (124:127)
06-19 07:06:38.027+0900 D/BADGE   ( 2376): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 07:06:38.027+0900 D/APPS    ( 2376): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
06-19 07:06:38.027+0900 D/APPS    ( 2376): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.sensors2]'s ordering : 1
06-19 07:06:38.027+0900 D/APPS    ( 2376): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.scorekeeperforgear]'s ordering : 2
06-19 07:06:38.027+0900 D/APPS    ( 2376): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb957c660 is terminated (NIL packet)
06-19 07:06:38.027+0900 D/DATA_PROVIDER_MASTER( 2417): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 07:06:38.037+0900 D/APPS    ( 2376): db.c: apps_db_update_item(374) >  Update the item[org.example.sensors2:1]
06-19 07:06:38.037+0900 D/rpm-installer( 6001): rpm-appcore-intf.c: main(227) > sync() end
06-19 07:06:38.037+0900 D/APPS    ( 2376): db.c: apps_db_insert_item(345) >  Insert the item[org.example.scorekeeperforgear:2]
06-19 07:06:38.037+0900 D/rpm-installer( 6001): rpm-appcore-intf.c: main(246) > ------------------------------------------------
06-19 07:06:38.037+0900 D/rpm-installer( 6001): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
06-19 07:06:38.037+0900 D/rpm-installer( 6001): rpm-appcore-intf.c: main(248) > ------------------------------------------------
06-19 07:06:38.037+0900 D/PKGMGR_SERVER( 5994): pkgmgr-server.c: sighandler(326) > child exit [6001]
06-19 07:06:38.037+0900 D/PKGMGR_SERVER( 5994): pkgmgr-server.c: sighandler(341) > child NORMAL exit [6001]
06-19 07:06:38.037+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 07:06:38.037+0900 D/PKGMGR  ( 2376): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 07:06:39.997+0900 D/PKGMGR_SERVER( 5994): pkgmgr-server.c: exit_server(724) > exit_server Start
06-19 07:06:39.997+0900 D/PKGMGR_SERVER( 5994): pkgmgr-server.c: main(1516) > Quit main loop.
06-19 07:06:39.997+0900 D/PKGMGR_SERVER( 5994): pkgmgr-server.c: main(1524) > package manager server terminated.
06-19 07:06:40.217+0900 D/AUL_AMD ( 2307): amd_request.c: __request_handler(506) > __request_handler: 0
06-19 07:06:40.217+0900 D/AUL_AMD ( 2307): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.scorekeeperforgear
06-19 07:06:40.217+0900 D/AUL     ( 2307): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 6058, pid = 6060
06-19 07:06:40.217+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
06-19 07:06:40.227+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1803) > process_pool: false
06-19 07:06:40.227+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-19 07:06:40.227+0900 D/AUL_AMD ( 2307): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.scorekeeperforgear
06-19 07:06:40.227+0900 D/AUL_AMD ( 2307): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-19 07:06:40.227+0900 D/AUL     ( 2307): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-19 07:06:40.227+0900 D/AUL_PAD ( 2328): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.scorekeeperforgear
06-19 07:06:40.227+0900 D/AUL_PAD ( 2328): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-19 07:06:40.227+0900 D/AUL_PAD ( 2328): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 6061 /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 07:06:40.227+0900 D/AUL_PAD ( 2328): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear / pkg_type : rpm / app_path : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear 
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear##
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-19 07:06:40.227+0900 D/AUL_PAD ( 6061): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-19 07:06:40.227+0900 D/LAUNCH  ( 6061): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear:Platform:launchpad:done]
06-19 07:06:40.227+0900 I/efl-extension( 6061): efl_extension.c: eext_mod_init(39) > Init
06-19 07:06:40.237+0900 W/CRASH_MANAGER( 5919): worker.c: worker_job(1189) > 110606173636f149782360
