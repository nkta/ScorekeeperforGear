S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170403.0854
Build-Date: 2017.04.03 08:54:58

Crash Information
Process Name: scorekeeperforgear
PID: 2864
Date: 2017-06-19 04:03:20+0900
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x46

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb41a3554, esi = 0x00000000
ebp = 0xbfbc5528, esp = 0xbfbc48d4
eax = 0xffffffff, ebx = 0xb75dcff4
ecx = 0x00000000, edx = 0xb75de430
eip = 0xb74bdec2

Memory Information
MemTotal:      123 KB
MemFree:        60 KB
Buffers:         2 KB
Cached:     136208 KB
VmPeak:      63248 KB
VmSize:      63248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        6996 KB
VmRSS:        6996 KB
VmData:       2228 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32636 KB
VmPTE:          52 KB
VmSwap:          0 KB

Maps Information
b3b64000 b3b67000 r-xp /usr/lib/libdri2.so.0.0.0
b3b68000 b3b73000 r-xp /usr/lib/libdrm.so.2.4.0
b3b74000 b3b7d000 r-xp /usr/lib/libtbm.so.1.0.0
b3b7e000 b3b85000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3b86000 b3b8f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3b90000 b3b97000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3b98000 b3ba0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3ba1000 b3ba5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3ba6000 b3bc3000 r-xp /usr/lib/libtts.so
b3bc4000 b3bda000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
b3bdb000 b3d1f000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d23000 b3d3b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d3c000 b3d42000 r-xp /usr/lib/libctx-client.so.0.8.3
b3d43000 b3d4d000 r-xp /usr/lib/libctx-shared.so.0.8.3
b3d4e000 b3d54000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3d55000 b3d67000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d68000 b3d8b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d8c000 b3d9c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3d9d000 b3dae000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b3db0000 b3db7000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3db8000 b3dc3000 r-xp /lib/libnss_files-2.13.so
b3fc5000 b3fec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3fed000 b4012000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4013000 b4134000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4144000 b4179000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b417b000 b417e000 r-xp /usr/lib/libiniparser.so.0
b4180000 b418a000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b418b000 b4194000 r-xp /usr/lib/libappsvc.so.0.1.0
b4195000 b4198000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4199000 b41a6000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
b41a8000 b41ae000 r-xp /usr/lib/libogg.so.0.7.1
b41af000 b41da000 r-xp /usr/lib/libvorbis.so.0.4.3
b41db000 b42c6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d4000 b42d6000 r-xp /usr/lib/libXau.so.6.0.0
b42d7000 b4330000 r-xp /usr/lib/libssl.so.1.0.0
b4335000 b4366000 r-xp /usr/lib/libidn.so.11.5.44
b4367000 b4377000 r-xp /usr/lib/libcares.so.2.1.0
b4378000 b43e1000 r-xp /usr/lib/libsndfile.so.1.0.25
b43e7000 b43f3000 r-xp /usr/lib/libsensord-shared.so
b43f4000 b441a000 r-xp /lib/libexpat.so.1.5.2
b441c000 b4443000 r-xp /usr/lib/libpng12.so.0.50.0
b4444000 b4464000 r-xp /usr/lib/libxcb.so.1.1.0
b4465000 b44d4000 r-xp /usr/lib/libcurl.so.4.3.0
b44d6000 b44e1000 r-xp /usr/lib/libethumb.so.1.7.99
b5d5e000 b5e36000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e42000 b5e45000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e46000 b5e5c000 r-xp /usr/lib/libremix.so.0.0.0
b5e5d000 b5e5f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e60000 b5e8c000 r-xp /usr/lib/liblua-5.1.so
b5e8d000 b5e97000 r-xp /usr/lib/libembryo.so.1.7.99
b5e98000 b5ede000 r-xp /usr/lib/libjpeg.so.8.0.2
b5eef000 b5f1e000 r-xp /usr/lib/libsensor.so.1.9.0
b5f1f000 b5fa1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fa6000 b5fda000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5fdc000 b6037000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6039000 b604f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6050000 b60dc000 r-xp /usr/lib/libfreetype.so.6.11.3
b60e0000 b60e3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60e4000 b60ea000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60eb000 b60f1000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60f3000 b6104000 r-xp /usr/lib/libXext.so.6.4.0
b6105000 b6239000 r-xp /usr/lib/libX11.so.6.3.0
b623d000 b6242000 r-xp /usr/lib/libXtst.so.6.1.0
b6243000 b624b000 r-xp /usr/lib/libXrender.so.1.3.0
b624c000 b6255000 r-xp /usr/lib/libXrandr.so.2.2.0
b6256000 b6258000 r-xp /usr/lib/libXinerama.so.1.0.0
b6259000 b6267000 r-xp /usr/lib/libXi.so.6.1.0
b6268000 b626c000 r-xp /usr/lib/libXfixes.so.3.1.0
b626d000 b626f000 r-xp /usr/lib/libXgesture.so.7.0.0
b6270000 b6272000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6273000 b6275000 r-xp /usr/lib/libXdamage.so.1.1.0
b6276000 b627f000 r-xp /usr/lib/libXcursor.so.1.0.2
b6280000 b62ab000 r-xp /usr/lib/libecore_con.so.1.7.99
b62ad000 b62b5000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62b6000 b62c1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62c2000 b62c8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b62c9000 b62ea000 r-xp /usr/lib/libefreet.so.1.7.99
b62ec000 b62f8000 r-xp /usr/lib/libedbus.so.1.7.99
b62f9000 b6488000 r-xp /usr/lib/libicuuc.so.57.1
b6497000 b6713000 r-xp /usr/lib/libicui18n.so.57.1
b671c000 b67ba000 r-xp /usr/lib/libedje.so.1.7.99
b67bc000 b67cd000 r-xp /usr/lib/libecore_input.so.1.7.99
b67ce000 b67d5000 r-xp /usr/lib/libecore_file.so.1.7.99
b67d6000 b67fc000 r-xp /usr/lib/libeet.so.1.7.99
b6805000 b692f000 r-xp /usr/lib/libevas.so.1.7.99
b694d000 b6981000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6983000 b69c7000 r-xp /usr/lib/libecore_x.so.1.7.99
b69c9000 b6bc4000 r-xp /usr/lib/libelementary.so.1.7.99
b6bd3000 b6bd5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6bd6000 b6bdc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bdd000 b6be1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6be6000 b6be7000 r-xp /usr/lib/libjournal.so.0.1.0
b6be8000 b6d30000 r-xp /usr/lib/libxml2.so.2.7.8
b6d36000 b6d49000 r-xp /lib/libresolv-2.13.so
b6d4d000 b6d6a000 r-xp /lib/libz.so.1.2.5
b6d6b000 b6d6e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d70000 b6d75000 r-xp /usr/lib/libffi.so.5.0.10
b6d76000 b6d77000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d78000 b6d7c000 r-xp /lib/libattr.so.1.1.0
b6d7d000 b6f90000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fab000 b6fcc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fce000 b6ff6000 r-xp /lib/libm-2.13.so
b6ff8000 b7053000 r-xp /usr/lib/libeina.so.1.7.99
b7055000 b7060000 r-xp /usr/lib/libvconf.so.0.2.45
b7061000 b7064000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7065000 b70b3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70b5000 b7216000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b721a000 b7221000 r-xp /lib/librt-2.13.so
b7223000 b722a000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b722c000 b7246000 r-xp /lib/libgcc_s-4.6.4.so.1
b7247000 b724f000 r-xp /lib/libcrypt-2.13.so
b7279000 b727d000 r-xp /lib/libcap.so.2.21
b727e000 b7280000 r-xp /usr/lib/libiri.so
b7281000 b72ad000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72ae000 b72ce000 r-xp /usr/lib/libecore.so.1.7.99
b72dd000 b72e6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72e7000 b740a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b740c000 b741f000 r-xp /usr/lib/libail.so.0.1.0
b7420000 b7445000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7446000 b7450000 r-xp /lib/libunwind.so.8.0.1
b745a000 b75da000 r-xp /lib/libc-2.13.so
b75e1000 b762b000 r-xp /usr/lib/libdbus-1.so.3.7.2
b762d000 b7632000 r-xp /usr/lib/libbundle.so.0.1.22
b7633000 b7636000 r-xp /lib/libdl-2.13.so
b7638000 b764f000 r-xp /lib/libpthread-2.13.so
b7653000 b7656000 r-xp /usr/lib/libdlog.so.0.0.0
b7657000 b7659000 r-xp /usr/lib/libttrace.so.1.1
b765a000 b765f000 r-xp /usr/lib/libsmack.so.1.0.0
b7660000 b7708000 r-xp /usr/lib/libsqlite3.so.0.8.6
b770b000 b7725000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7726000 b7736000 r-xp /usr/lib/libaul.so.0.1.0
b7739000 b773f000 r-xp /usr/lib/libappcore-common.so.1.1
b7740000 b7745000 r-xp /usr/lib/libappcore-efl.so.1.1
b7747000 b774c000 r-xp /usr/lib/libsys-assert.so
b774f000 b7750000 r-xp [vdso]
b7750000 b776e000 r-xp /lib/ld-2.13.so
b7770000 b7777000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2864)
Call Stack Count: 2
 0: fclose + 0x22 (0xb74bdec2) [/lib/libc.so.6] + 0x63ec2
 1: __libc_start_main + 0xf3 (0xb74731a3) [/lib/libc.so.6] + 0x191a3
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
: clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:end val:ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.scorekeeperforgear
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _end(651) >  Package(org.example.scorekeeperforgear) : key(update) - val(ok)
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.scorekeeperforgear, comp:ui, type:rpm
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.scorekeeperforgear]
06-19 04:03:07.109+0900 D/APPS    ( 2385): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.scorekeeperforgear]'s item object
06-19 04:03:07.109+0900 D/APPS    ( 2385): db.c: apps_db_remove_item(404) >  Remove the item[org.example.scorekeeperforgear]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 E/PKGMGR_INFO( 2265): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.119+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2974) > _ri_privilege_enable_permissions(privilege/appdebugging succeeded for debug_mode.
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(225) > sync() start
06-19 04:03:07.119+0900 D/APPS    ( 2385): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 04:03:07.119+0900 D/APPS    ( 2385): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 04:03:07.119+0900 D/BADGE   ( 2425): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 04:03:07.119+0900 E/DATA_PROVIDER_MASTER( 2425): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2425, fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2425), fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 68 (recv_fd: -1)
06-19 04:03:07.119+0900 D/APPS    ( 2385): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 04:03:07.119+0900 D/COM_CORE( 2425): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb794d850 is terminated (NIL packet)
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 04:03:07.119+0900 D/BADGE   ( 2425): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 04:03:07.119+0900 E/DATA_PROVIDER_MASTER( 2425): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2425, fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2425), fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 68 (recv_fd: -1)
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(227) > sync() end
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(246) > ------------------------------------------------
06-19 04:03:07.129+0900 D/COM_CORE( 2425): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 04:03:07.129+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb794d718 is terminated (NIL packet)
06-19 04:03:07.129+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
06-19 04:03:07.129+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 04:03:07.129+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(248) > ------------------------------------------------
06-19 04:03:07.129+0900 D/APPS    ( 2385): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 04:03:07.129+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: sighandler(326) > child exit [2760]
06-19 04:03:07.129+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: sighandler(341) > child NORMAL exit [2760]
06-19 04:03:07.129+0900 D/APPS    ( 2385): item.c: item_create(819) >  Icon size after ea_effect (124:127)
06-19 04:03:07.129+0900 D/BADGE   ( 2385): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.sensors2]'s ordering : 1
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.scorekeeperforgear]'s ordering : 2
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_update_item(374) >  Update the item[org.example.sensors2:1]
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_insert_item(345) >  Insert the item[org.example.scorekeeperforgear:2]
06-19 04:03:07.139+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.139+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: exit_server(724) > exit_server Start
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: main(1516) > Quit main loop.
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: main(1524) > package manager server terminated.
06-19 04:03:09.309+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(506) > __request_handler: 0
06-19 04:03:09.309+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.scorekeeperforgear
06-19 04:03:09.309+0900 D/AUL     ( 2324): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2817, pid = 2819
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1803) > process_pool: false
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-19 04:03:09.319+0900 D/AUL     ( 2324): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 2820 /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear / pkg_type : rpm / app_path : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear 
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear##
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-19 04:03:09.319+0900 D/LAUNCH  ( 2820): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear:Platform:launchpad:done]
06-19 04:03:09.319+0900 I/efl-extension( 2820): efl_extension.c: eext_mod_init(39) > Init
06-19 04:03:09.329+0900 W/CRASH_MANAGER( 2437): worker.c: worker_job(1189) > 110282073636f1497812589
06-19 04:03:09.339+0900 I/AUL_PAD ( 2343): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2820 pgid = 2820
06-19 04:03:09.339+0900 I/AUL_PAD ( 2343): sigchild.h: __sigchild_action(123) > dead_pid(2820)
06-19 04:03:09.339+0900 D/AUL_PAD ( 2343): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-19 04:03:09.339+0900 I/AUL_PAD ( 2343): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-19 04:03:09.339+0900 I/AUL_PAD ( 2343): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-19 04:03:09.339+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.339+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.339+0900 D/STARTER ( 2381): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2820)
06-19 04:03:09.339+0900 D/W_HOME  ( 2385): main.c: _dead_cb(542) > PID(2820) is dead
06-19 04:03:09.339+0900 E/W_HOME  ( 2385): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-19 04:03:09.439+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.439+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.539+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.539+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.639+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.639+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.739+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.739+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.839+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.839+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.939+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:09.939+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.049+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.049+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.149+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.149+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.249+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.249+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.289+0900 D/PKGMGR_INFO( 2437): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear' and package_app_info.app_disable IN ('false','False')
06-19 04:03:10.349+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.349+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.449+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.449+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.549+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.549+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.649+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.649+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.749+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.749+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.849+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.849+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:10.959+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:10.959+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:11.059+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:11.059+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:11.159+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(545) > error founded when being launched with 2820
06-19 04:03:11.159+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:11.259+0900 E/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(567) > process launched, but cmdline not changed
06-19 04:03:11.259+0900 D/AUL_PAD ( 2343): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-19 04:03:11.259+0900 D/AUL_PAD ( 2343): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-19 04:03:11.259+0900 D/AUL_PAD ( 2343): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-19 04:03:11.259+0900 D/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-19 04:03:11.259+0900 E/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(264) > access
06-19 04:03:11.259+0900 I/AUL_AMD ( 2324): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2820
06-19 04:03:11.259+0900 D/AUL_AMD ( 2324): amd_key.c: _unregister_key_event(161) > ===key stack===
06-19 04:03:11.259+0900 D/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-19 04:03:11.259+0900 E/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(264) > access
06-19 04:03:11.259+0900 D/RESOURCED( 2503): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-19 04:03:11.259+0900 D/RESOURCED( 2503): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2324
06-19 04:03:11.259+0900 D/RESOURCED( 2503): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.scorekeeperforgear, pid 2820, type 4 
06-19 04:03:11.259+0900 E/RESOURCED( 2503): proc-process.c: proc_get_oom_score_adj(344) > [proc_get_oom_score_adj,344] fopen /proc/2820/oom_score_adj failed
06-19 04:03:11.259+0900 E/RESOURCED( 2503): proc-main.c: resourced_proc_status_change(541) > [resourced_proc_status_change,541] Empty pid or process not exists. 2820
06-19 04:03:11.259+0900 D/RESOURCED( 2503): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-19 04:03:12.259+0900 D/AUL_AMD ( 2324): amd_launch.c: __grab_timeout_handler(1222) > pid(2820) ecore_x_pointer_ungrab
06-19 04:03:12.259+0900 D/AUL_AMD ( 2324): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.scorekeeperforgear /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 04:03:12.259+0900 D/RUA     ( 2324): rua.c: rua_add_history(179) > rua_add_history start
06-19 04:03:12.259+0900 D/RUA     ( 2324): rua.c: rua_add_history(247) > rua_add_history ok
06-19 04:03:13.009+0900 D/MEDIA_SERVER_THUMB( 2426): media-server-thumb.c: _ms_thumb_agent_timer(575) > Timer is called.. Now killing media-thumbnail-server[2498]
06-19 04:03:13.009+0900 D/MEDIA_SERVER_THUMB( 2426): media-server-thumb.c: _ms_thumb_set_buffer(362) > [SECURE_LOG] Basic Size : 44, org_path : [1], dst_path : [1]
06-19 04:03:13.009+0900 D/MEDIA_SERVER_THUMB( 2426): media-server-thumb.c: _ms_thumb_agent_send_msg_to_thumb_server(502) > [SECURE_LOG] Sending msg to thumbnail server is successful
06-19 04:03:13.009+0900 W/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server-internal.c: _thumb_server_read_socket(415) > [SECURE_LOG] [32mReceived [5] (0) from PID(0)
06-19 04:03:13.009+0900 W/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server-internal.c: _thumb_server_read_socket(431) > [32mreceived KILL msg from thumbnail agent.
06-19 04:03:13.009+0900 D/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server-internal.c: _thumb_server_read_socket(447) > [SECURE_LOG] [0m/tmp/.media_ipc_clientuszwi6
06-19 04:03:13.009+0900 W/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server-internal.c: _thumb_server_read_socket(454) > [SECURE_LOG] [32mSent (0)
06-19 04:03:13.009+0900 W/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server-internal.c: _thumb_server_read_socket(459) > [32mShutting down...
06-19 04:03:13.009+0900 D/MEDIA_THUMBNAIL_SERVER( 2498): thumb-server.c: main(120) > [0mThumbnail server is shutting down...
06-19 04:03:13.009+0900 D/MEDIA_SERVER_THUMB( 2426): media-server-thumb.c: _ms_thumb_agent_send_msg_to_thumb_server(514) > [SECURE_LOG] recv  from thumb daemon is successful
06-19 04:03:13.009+0900 D/MEDIA_UTIL( 2426): media-util-ipc.c: ms_ipc_delete_client_socket(165) > [0msockfd 17 close
06-19 04:03:13.119+0900 E/MEDIA_SERVER( 2426): media-server-main.c: _ms_signal_handler(189) > [2498] Thumbnail server is stopped by media-server
06-19 04:03:13.579+0900 I/GESTURE ( 2187): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 04:03:13.629+0900 D/EFL     ( 2703): ecore_x<2703> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=30585 button=1
06-19 04:03:13.759+0900 D/EFL     ( 2703): ecore_x<2703> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=30767 button=1
06-19 04:03:13.759+0900 E/EFL     ( 2703): eina_module<2703> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-19 04:03:13.769+0900 D/AUL     ( 2703): app_sock.c: __app_send_raw_with_noreply(370) > pid(-2) : cmd(22)
06-19 04:03:13.769+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(506) > __request_handler: 22
06-19 04:03:13.769+0900 D/APP_CORE( 2703): appcore-efl.c: __after_loop(1081) > [APP 2703] PAUSE before termination
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): main.c: _window_focus_in_cb(848) > focus in
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): main.c: _resume_cb(564) > Resumed
06-19 04:03:13.769+0900 D/APPS    ( 2385): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
06-19 04:03:13.769+0900 E/efl-extension( 2385): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb7bdb198, elm_scroller, _activated_obj : 0xb7bdb198, activated : 1
06-19 04:03:13.769+0900 W/W_HOME  ( 2385): main.c: _resume_cb(589) > clock/widget resumed
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): clock_view.c: clock_view_event_handler(843) > event:10004 received
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
06-19 04:03:13.769+0900 D/W_HOME  ( 2385): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb7c7b9f0 is resumed
06-19 04:03:13.769+0900 E/APPS    ( 2385): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
06-19 04:03:13.769+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1334) > Receive msg from clien msg_domain=0 msg_id=0 size=10
06-19 04:03:13.769+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1335) >  ########## data : mc_resume
06-19 04:03:13.769+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1338) > ##### mc_resume
06-19 04:03:13.779+0900 D/DATA_PROVIDER_MASTER( 2425): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2385 is resumed
06-19 04:03:13.779+0900 D/DATA_PROVIDER_MASTER( 2425): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
06-19 04:03:13.779+0900 I/AUL_PAD ( 2343): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2703 pgid = 2703
06-19 04:03:13.779+0900 I/AUL_PAD ( 2343): sigchild.h: __sigchild_action(123) > dead_pid(2703)
06-19 04:03:13.779+0900 D/AUL_PAD ( 2343): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-19 04:03:13.779+0900 I/AUL_PAD ( 2343): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-19 04:03:13.779+0900 I/AUL_PAD ( 2343): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-19 04:03:13.779+0900 I/AUL_AMD ( 2324): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2703
06-19 04:03:13.779+0900 D/W_HOME  ( 2385): main.c: _dead_cb(542) > PID(2703) is dead
06-19 04:03:13.779+0900 D/AUL_AMD ( 2324): amd_key.c: _unregister_key_event(161) > ===key stack===
06-19 04:03:13.779+0900 D/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-19 04:03:13.779+0900 E/W_HOME  ( 2385): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-19 04:03:13.779+0900 E/AUL     ( 2324): simple_util.c: __trm_app_info_send_socket(264) > access
06-19 04:03:13.789+0900 D/STARTER ( 2381): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2703)
06-19 04:03:15.769+0900 D/AUL_AMD ( 2324): amd_status.c: __app_terminate_timer_cb(113) > pid(2703)
06-19 04:03:15.769+0900 D/AUL_AMD ( 2324): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
06-19 04:03:16.539+0900 I/GESTURE ( 2187): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 04:03:16.589+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=33542 button=1
06-19 04:03:16.589+0900 D/W_HOME  ( 2385): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-19 04:03:16.589+0900 D/W_HOME  ( 2385): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
06-19 04:03:16.589+0900 D/W_HOME  ( 2385): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:336
06-19 04:03:16.589+0900 D/W_HOME  ( 2385): layout.c: _down_cb(250) > Mouse is down on the layout
06-19 04:03:16.589+0900 W/W_HOME  ( 2385): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
06-19 04:03:16.589+0900 D/W_HOME  ( 2385): page.c: _down_cb(84) > Down (0xb7c18bc0)(169, 336)
06-19 04:03:16.629+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=33632 button=1
06-19 04:03:16.629+0900 D/W_HOME  ( 2385): layout.c: _up_cb(324) > Mouse is up on the layout
06-19 04:03:16.629+0900 D/W_HOME  ( 2385): page.c: _up_cb(115) > Up (0xb7c18bc0)(168, 337)
06-19 04:03:17.199+0900 I/GESTURE ( 2187): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 04:03:17.249+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=34208 button=1
06-19 04:03:17.249+0900 D/W_HOME  ( 2385): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-19 04:03:17.249+0900 D/W_HOME  ( 2385): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
06-19 04:03:17.249+0900 D/W_HOME  ( 2385): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:312
06-19 04:03:17.249+0900 D/W_HOME  ( 2385): layout.c: _down_cb(250) > Mouse is down on the layout
06-19 04:03:17.249+0900 W/W_HOME  ( 2385): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
06-19 04:03:17.249+0900 D/W_HOME  ( 2385): page.c: _down_cb(84) > Down (0xb7c18bc0)(163, 312)
06-19 04:03:17.269+0900 D/W_HOME  ( 2385): layout.c: _bezel_up_cb(348) > Bezel up cb
06-19 04:03:17.269+0900 D/APPS    ( 2385): apps_main.c: apps_main_launch(588) >  APPS LAUNCH
06-19 04:03:17.269+0900 D/APPS    ( 2385): apps_main.c: apps_main_launch(618) >  Show the Apps
06-19 04:03:17.269+0900 D/APPS    ( 2385): apps_main.c: apps_main_launch(625) >  There is a window already
06-19 04:03:17.269+0900 D/APPS    ( 2385): layout.c: apps_layout_show(476) >  (0xb7c7df50) Show the tray
06-19 04:03:17.329+0900 D/APP_CORE( 2385): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600007
06-19 04:03:17.329+0900 D/APP_CORE( 2385): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1600007
06-19 04:03:17.329+0900 D/W_HOME  ( 2385): main.c: _window_focus_out_cb(869) > focus out
06-19 04:03:17.329+0900 D/W_HOME  ( 2385): main.c: _pause_cb(600) > Paused
06-19 04:03:17.329+0900 D/W_HOME  ( 2385): page.c: page_focus(696) > focus set to 0xb7cbb908
06-19 04:03:17.329+0900 W/W_HOME  ( 2385): main.c: _pause_cb(613) > clock/widget paused
06-19 04:03:17.329+0900 D/W_HOME  ( 2385): clock_view.c: clock_view_event_handler(843) > event:10002 received
06-19 04:03:17.329+0900 D/W_HOME  ( 2385): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb7c7b9f0 is paused
06-19 04:03:17.329+0900 E/APPS    ( 2385): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
06-19 04:03:17.329+0900 E/W_HOME  ( 2385): main.c: _window_focus_in_cb(851) > win[23068675], ev->win[23068679]
06-19 04:03:17.329+0900 D/APPS    ( 2385): apps_main.c: _window_focus_in_cb(288) >  focus in
06-19 04:03:17.329+0900 E/W_HOME  ( 2385): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
06-19 04:03:17.329+0900 D/APPS    ( 2385): apps_main.c: apps_main_resume(693) >  Resume starts
06-19 04:03:17.329+0900 D/APPS    ( 2385): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
06-19 04:03:17.329+0900 E/efl-extension( 2385): efl_extension_rotary.c: eext_rotary_object_event_activated_set(299) > eext_rotary_object_event_activated_set : 0xb7cd0820, elm_scroller, _activated_obj : 0xb7bdb198, activated : 1
06-19 04:03:17.329+0900 E/efl-extension( 2385): efl_extension_rotary.c: eext_rotary_object_event_activated_set(307) > Activation delete!!!!
06-19 04:03:17.329+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1334) > Receive msg from clien msg_domain=0 msg_id=0 size=9
06-19 04:03:17.329+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1335) >  ########## data : mc_pause
06-19 04:03:17.329+0900 D/IDLE-CLOCK-DIGITAL( 2391): clock_view.c: _ecore_evas_msg_parent_handle(1340) > ##### mc_pause
06-19 04:03:17.359+0900 D/DATA_PROVIDER_MASTER( 2425): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2385 is paused
06-19 04:03:17.359+0900 D/DATA_PROVIDER_MASTER( 2425): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1600007 fully_obscured 0
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active 1
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __visibility_cb(922) >  No change state 
06-19 04:03:17.359+0900 W/W_HOME  ( 2385): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active 1
06-19 04:03:17.359+0900 D/APP_CORE( 2385): appcore-efl.c: __visibility_cb(922) >  No change state 
06-19 04:03:17.479+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=34487 button=1
06-19 04:03:17.479+0900 D/W_HOME  ( 2385): layout.c: _up_cb(324) > Mouse is up on the layout
06-19 04:03:17.479+0900 D/W_HOME  ( 2385): page.c: _up_cb(115) > Up (0xb7c18bc0)(132, 70)
06-19 04:03:17.479+0900 D/W_HOME  ( 2385): page.c: _up_cb(129) > Event ON_HOLD flag set on a page(0xb7c18bc0)
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 36352
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 36352
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 04:03:19.349+0900 E/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb92124e8, WRT_VIEW, 1
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 04:03:19.349+0900 I/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb010b6f8
06-19 04:03:19.349+0900 E/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb7cd0820, elm_scroller, 1
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb7cd0820, elm_scroller, time_stamp : 36352
06-19 04:03:19.349+0900 D/APPS    ( 2385): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 04:03:19.349+0900 D/APPS    ( 2385): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb7cd0820], direction[0], timeStamp[36352]
06-19 04:03:19.349+0900 D/APPS    ( 2385): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 04:03:19.349+0900 D/APPS    ( 2385): scroller.c: _anim_start_cb(122) >  start the scroller animation
06-19 04:03:19.349+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb7df3c28
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 36511
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 04:03:19.509+0900 E/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb92124e8, WRT_VIEW, 1
06-19 04:03:19.509+0900 I/efl-extension( 2390): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb0102968
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(429) > In
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(444) > time stamp: 36511
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(449) > raw dir: 1
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _process_raw_event(460) > direction: Clockwise
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_event_cb(482) > In
06-19 04:03:19.509+0900 E/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_handler_cb(522) > _rotary_rotate_handler_cb : 0xb7cd0820, elm_scroller, 1
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_handler_cb(542) > Deliver clockwise rotary event to object: 0xb7cd0820, elm_scroller, time_stamp : 36511
06-19 04:03:19.509+0900 D/APPS    ( 2385): scroller.c: _rotary_cb(62) >  Rotary callback is called
06-19 04:03:19.509+0900 D/APPS    ( 2385): scroller.c: _rotary_cb(67) >  Detent detected, obj[0xb7cd0820], direction[0], timeStamp[36511]
06-19 04:03:19.509+0900 D/APPS    ( 2385): scroller.c: apps_scroller_bring_in_region_by_vector(1206) >  Apps scroller bring in region by vector: 1
06-19 04:03:19.509+0900 D/APPS    ( 2385): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
06-19 04:03:19.509+0900 D/APPS    ( 2385): scroller.c: _anim_start_cb(122) >  start the scroller animation
06-19 04:03:19.509+0900 I/efl-extension( 2385): efl_extension_rotary.c: _rotary_rotate_event_free(413) > In: ddata: 0xb7df1e48
06-19 04:03:19.729+0900 D/APPS    ( 2385): scroller.c: _anim_stop_cb(140) >  stop the scroller animation
06-19 04:03:20.499+0900 I/GESTURE ( 2187): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-19 04:03:20.549+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=37503 button=1
06-19 04:03:20.549+0900 D/APPS    ( 2385): scroller.c: _mouse_down_cb(100) >  Mouse is down [87,221]
06-19 04:03:20.549+0900 D/APPS    ( 2385): item.c: _down_cb(381) >  Down (scorekeeperforgear,0xb7e2f010) (87, 221), item pos(41,1,280,390)
06-19 04:03:20.549+0900 E/APPS    ( 2385): item.c: _down_cb(425) >  longpress edit mode disable
06-19 04:03:20.559+0900 D/EFL     ( 2385): ecore_x<2385> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=37565 button=1
06-19 04:03:20.559+0900 D/APPS    ( 2385): scroller.c: _mouse_up_cb(111) >  Mouse is up [87,221]
06-19 04:03:20.559+0900 D/APPS    ( 2385): item.c: _up_cb(573) >  Up (scorekeeperforgear,0xb7e2f010) (87, 221), item pos(41,1,280,390)
06-19 04:03:20.559+0900 E/APPS    ( 2385): item.c: _clicked_cb(65) >  Clicked
06-19 04:03:20.559+0900 E/APPS    ( 2385): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-19 04:03:20.559+0900 D/APPS    ( 2385): item.c: _clicked_cb(95) >  item(rpm) launched to aul_launch
06-19 04:03:20.559+0900 D/APP_SVC ( 2385): appsvc.c: __set_bundle(161) > __set_bundle
06-19 04:03:20.559+0900 D/APP_SVC ( 2385): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
06-19 04:03:20.559+0900 D/APP_SVC ( 2385): appsvc.c: __set_bundle(161) > __set_bundle
06-19 04:03:20.559+0900 D/W_HOME  ( 2385): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
06-19 04:03:20.559+0900 D/W_HOME  ( 2385): dbus_util.c: home_dbus_cpu_booster_signal_send(278) > Sending cpu booster call:200 result:0
06-19 04:03:20.559+0900 D/APP_SVC ( 2385): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear - no result
06-19 04:03:20.559+0900 D/AUL     ( 2385): launch.c: app_request_to_launchpad(287) > [SECURE_LOG] launch request : org.example.scorekeeperforgear
06-19 04:03:20.559+0900 D/AUL     ( 2385): app_sock.c: __app_send_raw(270) > pid(-2) : cmd(0)
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(506) > __request_handler: 0
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.scorekeeperforgear
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : org.tizen.w-home
06-19 04:03:20.559+0900 E/AUL_AMD ( 2324): amd_launch.c: invoke_dbus_method_sync(1200) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1708) > org.tizen.system.coord.rotation-Degree : -74
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1803) > process_pool: false
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.scorekeeperforgear
06-19 04:03:20.559+0900 D/AUL_AMD ( 2324): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-19 04:03:20.559+0900 D/AUL     ( 2324): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-19 04:03:20.559+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.scorekeeperforgear
06-19 04:03:20.559+0900 D/AUL_PAD ( 2343): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-19 04:03:20.559+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 2864 /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 04:03:20.559+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:20.559+0900 D/AUL_PAD ( 2864): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-19 04:03:20.559+0900 D/AUL_PAD ( 2864): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-19 04:03:20.559+0900 D/AUL_PAD ( 2864): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear / pkg_type : rpm / app_path : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear 
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear##
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-19 04:03:20.569+0900 D/AUL_PAD ( 2864): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-19 04:03:20.569+0900 D/LAUNCH  ( 2864): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear:Platform:launchpad:done]
06-19 04:03:20.569+0900 I/efl-extension( 2864): efl_extension.c: eext_mod_init(39) > Init
06-19 04:03:20.579+0900 W/CRASH_MANAGER( 2437): worker.c: worker_job(1189) > 110286473636f149781260
