using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Mines
{
    public partial class Form1 : Form
    {
        private RadioButton[] levels;
        private Dictionary<RadioButton, int> gridSize;
        private DataGridViewTextBoxColumn[] cols;
        private bool GameOn = false;
        private bool FirstClick = true;
        private int countMine = 0;
        private Stopwatch stopwatch = new Stopwatch();
        Task taskTimer;
        CancellationToken tokenTimer;
        CancellationTokenSource tsTimer;
        private int[,] Canvas;
        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            InitializeSizeDic();
            InitializeLevels();
            InitializeCols();
        }
        private void InitializeCols()
        {
            cols = new DataGridViewTextBoxColumn[20] {Column1,Column2,Column3,Column4,Column5,Column6,Column7,
                Column8,Column9,Column10,Column11,Column12,Column13,
                Column14,Column15,Column16,Column17,Column18,Column19,Column20};
        }
        private void InitializeSizeDic()
        {
            gridSize = new Dictionary<RadioButton, int>() { [radio_level1] = 10, [radio_level2] = 15, [radio_level3] = 20 };
        }
        private void InitializeLevels()
        {
            levels = new RadioButton[] { radio_level1, radio_level2, radio_level3 };
        }
        private void PaintBlankCanvas()
        {
            int size = 0;
            canvasGrid.Rows.Clear();
            //��ȡɨ�����̵ĳߴ磬Ҳ�����׸���
            foreach (RadioButton rb in levels)
            {
                if (rb.Checked)
                {
                    size = gridSize[rb];
                }
            }
            for (int i = 0; i < size - 1; i++)
            {
                string[] row0 = new string[size];
                canvasGrid.Rows.Add(row0);
            }
            for (int i = 0; i < size; i++)
            {
                cols[i].Visible = true;
            }
            for (int i = size; i < 20; i++)
            {
                cols[i].Visible = false;
            }

            canvasGrid.Refresh();
        }
        //po��ʾ��һ�ε�������ʱ���λ��
        private void InitializeCanvas(Point p0)
        {
            int size = 0;
            //��ȡɨ�����̵ĳߴ磬Ҳ�����׸���
            foreach (RadioButton rb in levels)
            {
                if (rb.Checked)
                {
                    size = gridSize[rb];
                }
            }
            //Canvas�������̲���
            Canvas = new int[size, size];
            //bombs����ը��λ��
            List<Point> bombs = new List<Point>(size);
            int x;
            int y;
            //���ѡ��size����ͬ�ĵ����ը��
            for (int i = 0; i < size; i++)
            {
                Random random = new Random();
                x = random.Next(size);
                y = random.Next(size);
                //ע��ը�����ܷ��ڳ�ʼ���µ�λ��
                while (bombs.Contains(p0))
                {
                    x = random.Next(size);
                    y = random.Next(size);
                }
                while (bombs.Contains(new Point(x, y)))
                {
                    x = random.Next(size);
                    y = random.Next(size);
                }
                bombs.Add(new Point(x, y));
            }
            //��ը���Ž�ȥ
            for (int i = 0; i < size; i++)
            {
                Canvas[bombs[i].X, bombs[i].Y] = int.MaxValue;
            }
            //��һ���ո��Ա��м���ը��
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Canvas[i, j] == int.MaxValue) continue;
                    //��ʼ��Ϊ0
                    int count = 0;
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        //count���ը������
                       
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            if (dx == 0 && dy ==0 ) continue;
                            int nx = i + dx;
                            int ny = j + dy;
                            if (nx < 0 || nx >= size || ny < 0 || ny >= size) continue;
                            if (Canvas[nx, ny] == int.MaxValue)
                            {
                                count++;
                            }
                        }
                        
                    }
                    Canvas[i, j] = count;
                }
            }
        }
        #region radioButton��������ʵ��
        private void radio_level1_CheckedChanged(object sender, EventArgs e)
        {
            radio_level1.Checked = true;
            radio_level2.Checked = false;
            radio_level3.Checked = false;
        }

        private void radio_level2_CheckedChanged(object sender, EventArgs e)
        {
            radio_level2.Checked = true;
            radio_level1.Checked = false;
            radio_level3.Checked = false;
        }

        private void radio_level3_CheckedChanged(object sender, EventArgs e)
        {
            radio_level3.Checked = true;
            radio_level2.Checked = false;
            radio_level1.Checked = false;
        }
        #endregion
        private string TimerLabel(int second)
        {
            //��ʱ������1Сʱ
            if (second >= 60 * 60)
            {
                return "����1Сʱ";
            }
            string min = Convert.ToString(second / 60).PadLeft(2, '0');
            string sec = Convert.ToString(second % 60).PadLeft(2, '0');
            return min + ":" + sec;
        }
        public async Task RunAsyncTimer(CancellationToken ct)
        {
            if (ct.IsCancellationRequested) return;
            await Task.Run(() => UpdateTImer(ct), ct);
        }
        private void UpdateTImer(CancellationToken token)
        {
            while (true)
            {
                label_timer.Invoke((EventHandler)delegate
                {
                    label_timer.Text = "��ʱ  " + TimerLabel((int)(stopwatch.ElapsedMilliseconds / 1000));
                });
                Thread.Sleep(200);
            }

        }
        private void button_restart_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            if (!GameOn)
            {
                GameOn = true;
                FirstClick = true;
                button_result.ImageIndex = 0;
                stopwatch.Reset();
                stopwatch.Start();
                tsTimer = new CancellationTokenSource();
                tokenTimer = tsTimer.Token;
                taskTimer = RunAsyncTimer(tokenTimer);
                PaintBlankCanvas();

            }
            else
            {
                GameOn = false;
                stopwatch.Stop();
                tsTimer.Cancel();
            }
        }

        private void canvasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //��δ��ʼ��Ϸ�������Ч
            if (!GameOn) return;
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            //������������Ч
            if (row < 0 || col < 0) return;

            if (FirstClick)
            {
                InitializeCanvas(new Point(row, col));
                FirstClick = false;
                countMine = 1;
            }
            DataGridViewCell cell = canvasGrid.Rows[row].Cells[col];
            int curr = Canvas[row, col];
            if (curr == int.MaxValue)
            {
                cell.Value = "*";
                cell.Style.BackColor = Color.Red;
                MessageBox.Show("You're dead");
                GameOn = false;
                return;

            }
            else
            {
                if(curr==0)
                {
                    cell.Value = "";
                }
                else
                {
                    cell.Value = curr.ToString();
                }
                cell.Style.BackColor = Color.Green;
                countMine++;
            }
            int size = canvasGrid.Rows.Count;
            if (countMine == size * size - size)
            {
                button_result.ImageIndex = 1;
                MessageBox.Show("You WON");
                GameOn = false;
                return;
            }
        }
    }
}