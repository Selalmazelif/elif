private void lstiller_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstiller.SelectedItems.Count > 0)
            {
                lstiller.DoDragDrop(lstiller, DragDropEffects.Move);

            }

        }

        private void lstiller2_DragOver(object sender, DragEventArgs e)
        {
            var tasınanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;

            if (tasınanData != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void lstiller2_DragDrop(object sender, DragEventArgs e)
        {
            var tasınanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenindeskler = tasınanData.SelectedIndices;
            foreach (int item in secilenindeskler)
            {
                lstiller2.Items.Add(lstiller.Items[item]);
            }
            for (int i = secilenindeskler.Count - 1; i >= 0; i--)
            {
                lstiller.Items.RemoveAt(secilenindeskler[i]);
            }

        }


        private void lstiller2_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstiller2.SelectedItems.Count > 0)
            {
                lstiller2.DoDragDrop(lstiller2, DragDropEffects.Move);

            }
        }




        private void lstiller_DragOver(object sender, DragEventArgs e)
        {
            var tasınanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;

            if (tasınanData != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstiller_DragDrop(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;

            if(tasinanData!=null&& tasinanData==lstiller2)
            {
                var secilenindesler = lstiller2.SelectedIndices;
                foreach(int item in secilenindesler)
                {
                    lstiller.Items.Add(lstiller2.Items[item]);
                }
                for(int i=secilenindesler.Count-1;i>=0;i--)
                {
                    lstiller2.Items.RemoveAt(secilenindesler[i]);
                }
                    
            }
        }

        

    }
}
