/* --------------------------------------------------------------------------
 * Copyrights
 *
 * Portions created by or assigned to Cursive Systems, Inc. are
 * Copyright (c) 2002-2008 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at
 * http://www.cursive.net/.
 *
 * License
 *
 * Jabber-Net can be used under either JOSL or the GPL.
 * See LICENSE.txt for details.
 * --------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using jabber.connection;
using System.Threading;

namespace test.bedrock.net
{
    /// <summary>
    /// TODO: This test is known to not work.  Add one that does, please.
    /// </summary>
    [TestFixture]
    public class HttpUploadTest
    {
        private object m_lock = new object();

        private void uploader_OnUpload(object sender)
        {
            lock(m_lock)
            {
                Monitor.Pulse(m_lock);
            }
        }

        [Test]
        public void UploadFile()
        {
            /*
            m_lock = new object();

            HttpUploader uploader = new HttpUploader();
            uploader.OnUpload += new global::bedrock.ObjectHandler(uploader_OnUpload);
            uploader.Upload("http://opodsadny.kiev.luxoft.com:7335/webclient", "les@primus.com/Bass", "upload.txt");
            lock (m_lock)
            {
                Monitor.Wait(m_lock);
            }
             */
        }
    }
}