
package View;

import java.awt.event.KeyEvent;
import javax.swing.JOptionPane;

public class Tela extends javax.swing.JFrame {

    private double parcial=0, total=0;
    private String op="",textodecima="",textoantigo="";
    private boolean ponto=false, continuar=false, operacao=false, botaoIgual=false;
    public Tela() {
        initComponents();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        n2 = new javax.swing.JButton();
        n1 = new javax.swing.JButton();
        n3 = new javax.swing.JButton();
        n4 = new javax.swing.JButton();
        n5 = new javax.swing.JButton();
        n6 = new javax.swing.JButton();
        n7 = new javax.swing.JButton();
        n8 = new javax.swing.JButton();
        n9 = new javax.swing.JButton();
        soma = new javax.swing.JButton();
        subtracao = new javax.swing.JButton();
        multiplicacao = new javax.swing.JButton();
        divisao = new javax.swing.JButton();
        texto = new javax.swing.JTextField();
        valor = new javax.swing.JTextField();
        maisemenos = new javax.swing.JButton();
        apagartudo = new javax.swing.JButton();
        apagartudo1 = new javax.swing.JButton();
        apagartudo2 = new javax.swing.JButton();
        n0 = new javax.swing.JButton();
        igual = new javax.swing.JButton();
        n10 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Calculadora");
        setResizable(false);

        jPanel1.setBackground(new java.awt.Color(255, 255, 255));

        n2.setBackground(new java.awt.Color(255, 255, 255));
        n2.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n2.setText("2");
        n2.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n2.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n2.setMaximumSize(new java.awt.Dimension(125, 57));
        n2.setMinimumSize(new java.awt.Dimension(125, 57));
        n2.setPreferredSize(new java.awt.Dimension(100, 75));
        n2.setRequestFocusEnabled(false);
        n2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n2ActionPerformed(evt);
            }
        });

        n1.setBackground(new java.awt.Color(255, 255, 255));
        n1.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n1.setText("1");
        n1.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n1.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n1.setMaximumSize(new java.awt.Dimension(125, 57));
        n1.setMinimumSize(new java.awt.Dimension(125, 57));
        n1.setPreferredSize(new java.awt.Dimension(100, 75));
        n1.setRequestFocusEnabled(false);
        n1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n1ActionPerformed(evt);
            }
        });

        n3.setBackground(new java.awt.Color(255, 255, 255));
        n3.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n3.setText("3");
        n3.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n3.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n3.setMaximumSize(new java.awt.Dimension(125, 57));
        n3.setMinimumSize(new java.awt.Dimension(125, 57));
        n3.setPreferredSize(new java.awt.Dimension(100, 75));
        n3.setRequestFocusEnabled(false);
        n3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n3ActionPerformed(evt);
            }
        });

        n4.setBackground(new java.awt.Color(255, 255, 255));
        n4.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n4.setText("4");
        n4.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n4.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n4.setMaximumSize(new java.awt.Dimension(125, 57));
        n4.setMinimumSize(new java.awt.Dimension(125, 57));
        n4.setPreferredSize(new java.awt.Dimension(100, 75));
        n4.setRequestFocusEnabled(false);
        n4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n4ActionPerformed(evt);
            }
        });

        n5.setBackground(new java.awt.Color(255, 255, 255));
        n5.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n5.setText("5");
        n5.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n5.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n5.setMaximumSize(new java.awt.Dimension(125, 57));
        n5.setMinimumSize(new java.awt.Dimension(125, 57));
        n5.setPreferredSize(new java.awt.Dimension(100, 75));
        n5.setRequestFocusEnabled(false);
        n5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n5ActionPerformed(evt);
            }
        });

        n6.setBackground(new java.awt.Color(255, 255, 255));
        n6.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n6.setText("6");
        n6.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n6.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n6.setMaximumSize(new java.awt.Dimension(125, 57));
        n6.setMinimumSize(new java.awt.Dimension(125, 57));
        n6.setPreferredSize(new java.awt.Dimension(100, 75));
        n6.setRequestFocusEnabled(false);
        n6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n6ActionPerformed(evt);
            }
        });

        n7.setBackground(new java.awt.Color(255, 255, 255));
        n7.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n7.setText("7");
        n7.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n7.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n7.setMaximumSize(new java.awt.Dimension(125, 57));
        n7.setMinimumSize(new java.awt.Dimension(125, 57));
        n7.setPreferredSize(new java.awt.Dimension(100, 75));
        n7.setRequestFocusEnabled(false);
        n7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n7ActionPerformed(evt);
            }
        });

        n8.setBackground(new java.awt.Color(255, 255, 255));
        n8.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n8.setText("8");
        n8.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n8.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n8.setMaximumSize(new java.awt.Dimension(125, 57));
        n8.setMinimumSize(new java.awt.Dimension(125, 57));
        n8.setPreferredSize(new java.awt.Dimension(100, 75));
        n8.setRequestFocusEnabled(false);
        n8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n8ActionPerformed(evt);
            }
        });

        n9.setBackground(new java.awt.Color(255, 255, 255));
        n9.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n9.setText("9");
        n9.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n9.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n9.setMaximumSize(new java.awt.Dimension(125, 57));
        n9.setMinimumSize(new java.awt.Dimension(125, 57));
        n9.setPreferredSize(new java.awt.Dimension(100, 75));
        n9.setRequestFocusEnabled(false);
        n9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n9ActionPerformed(evt);
            }
        });

        soma.setBackground(new java.awt.Color(235, 235, 235));
        soma.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        soma.setText("+");
        soma.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        soma.setMargin(new java.awt.Insets(0, 0, 0, 0));
        soma.setMaximumSize(new java.awt.Dimension(125, 57));
        soma.setMinimumSize(new java.awt.Dimension(125, 57));
        soma.setPreferredSize(new java.awt.Dimension(100, 75));
        soma.setRequestFocusEnabled(false);
        soma.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                somaActionPerformed(evt);
            }
        });

        subtracao.setBackground(new java.awt.Color(235, 235, 235));
        subtracao.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        subtracao.setText("-");
        subtracao.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        subtracao.setMargin(new java.awt.Insets(0, 0, 0, 0));
        subtracao.setMaximumSize(new java.awt.Dimension(125, 57));
        subtracao.setMinimumSize(new java.awt.Dimension(125, 57));
        subtracao.setPreferredSize(new java.awt.Dimension(100, 75));
        subtracao.setRequestFocusEnabled(false);
        subtracao.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                subtracaoActionPerformed(evt);
            }
        });

        multiplicacao.setBackground(new java.awt.Color(235, 235, 235));
        multiplicacao.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        multiplicacao.setText("X");
        multiplicacao.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        multiplicacao.setMargin(new java.awt.Insets(0, 0, 0, 0));
        multiplicacao.setMaximumSize(new java.awt.Dimension(125, 57));
        multiplicacao.setMinimumSize(new java.awt.Dimension(125, 57));
        multiplicacao.setPreferredSize(new java.awt.Dimension(100, 75));
        multiplicacao.setRequestFocusEnabled(false);
        multiplicacao.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                multiplicacaoActionPerformed(evt);
            }
        });

        divisao.setBackground(new java.awt.Color(235, 235, 235));
        divisao.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        divisao.setText("/");
        divisao.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        divisao.setMargin(new java.awt.Insets(0, 0, 0, 0));
        divisao.setMaximumSize(new java.awt.Dimension(125, 57));
        divisao.setMinimumSize(new java.awt.Dimension(125, 57));
        divisao.setPreferredSize(new java.awt.Dimension(100, 75));
        divisao.setRequestFocusEnabled(false);
        divisao.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                divisaoActionPerformed(evt);
            }
        });

        texto.setFont(new java.awt.Font("Tahoma", 0, 36)); // NOI18N
        texto.setText("0");
        texto.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        texto.addMouseMotionListener(new java.awt.event.MouseMotionAdapter() {
            public void mouseMoved(java.awt.event.MouseEvent evt) {
                textoMouseMoved(evt);
            }
        });
        texto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                textoActionPerformed(evt);
            }
        });
        texto.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                textoKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                textoKeyTyped(evt);
            }
        });

        valor.setFont(new java.awt.Font("Tahoma", 0, 16)); // NOI18N
        valor.setBorder(javax.swing.BorderFactory.createTitledBorder(""));
        valor.setDisabledTextColor(new java.awt.Color(0, 0, 0));
        valor.setEnabled(false);
        valor.setSelectedTextColor(new java.awt.Color(51, 51, 51));
        valor.setSelectionColor(new java.awt.Color(0, 0, 0));
        valor.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                valorActionPerformed(evt);
            }
        });

        maisemenos.setBackground(new java.awt.Color(235, 235, 235));
        maisemenos.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        maisemenos.setText("+-");
        maisemenos.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        maisemenos.setMargin(new java.awt.Insets(0, 0, 0, 0));
        maisemenos.setMaximumSize(new java.awt.Dimension(125, 57));
        maisemenos.setMinimumSize(new java.awt.Dimension(125, 57));
        maisemenos.setPreferredSize(new java.awt.Dimension(100, 75));
        maisemenos.setRequestFocusEnabled(false);
        maisemenos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                maisemenosActionPerformed(evt);
            }
        });

        apagartudo.setBackground(new java.awt.Color(235, 235, 235));
        apagartudo.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        apagartudo.setText("C");
        apagartudo.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        apagartudo.setMargin(new java.awt.Insets(0, 0, 0, 0));
        apagartudo.setMaximumSize(new java.awt.Dimension(125, 57));
        apagartudo.setMinimumSize(new java.awt.Dimension(125, 57));
        apagartudo.setPreferredSize(new java.awt.Dimension(100, 75));
        apagartudo.setRequestFocusEnabled(false);
        apagartudo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                apagartudoActionPerformed(evt);
            }
        });

        apagartudo1.setBackground(new java.awt.Color(235, 235, 235));
        apagartudo1.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        apagartudo1.setText("CE");
        apagartudo1.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        apagartudo1.setMargin(new java.awt.Insets(0, 0, 0, 0));
        apagartudo1.setMaximumSize(new java.awt.Dimension(125, 57));
        apagartudo1.setMinimumSize(new java.awt.Dimension(125, 57));
        apagartudo1.setPreferredSize(new java.awt.Dimension(100, 75));
        apagartudo1.setRequestFocusEnabled(false);
        apagartudo1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                apagartudo1ActionPerformed(evt);
            }
        });

        apagartudo2.setBackground(new java.awt.Color(235, 235, 235));
        apagartudo2.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        apagartudo2.setText("DEL");
        apagartudo2.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        apagartudo2.setMargin(new java.awt.Insets(0, 0, 0, 0));
        apagartudo2.setMaximumSize(new java.awt.Dimension(125, 57));
        apagartudo2.setMinimumSize(new java.awt.Dimension(125, 57));
        apagartudo2.setPreferredSize(new java.awt.Dimension(100, 75));
        apagartudo2.setRequestFocusEnabled(false);
        apagartudo2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                apagartudo2ActionPerformed(evt);
            }
        });

        n0.setBackground(new java.awt.Color(255, 255, 255));
        n0.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n0.setText("0");
        n0.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n0.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n0.setMaximumSize(new java.awt.Dimension(125, 57));
        n0.setMinimumSize(new java.awt.Dimension(125, 57));
        n0.setPreferredSize(new java.awt.Dimension(100, 75));
        n0.setRequestFocusEnabled(false);
        n0.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n0ActionPerformed(evt);
            }
        });

        igual.setBackground(new java.awt.Color(204, 204, 204));
        igual.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        igual.setText("=");
        igual.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        igual.setMargin(new java.awt.Insets(0, 0, 0, 0));
        igual.setMaximumSize(new java.awt.Dimension(125, 57));
        igual.setMinimumSize(new java.awt.Dimension(125, 57));
        igual.setPreferredSize(new java.awt.Dimension(100, 75));
        igual.setRequestFocusEnabled(false);
        igual.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                igualActionPerformed(evt);
            }
        });

        n10.setBackground(new java.awt.Color(255, 255, 255));
        n10.setFont(new java.awt.Font("Dialog", 1, 18)); // NOI18N
        n10.setText(".");
        n10.setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        n10.setMargin(new java.awt.Insets(0, 0, 0, 0));
        n10.setMaximumSize(new java.awt.Dimension(125, 57));
        n10.setMinimumSize(new java.awt.Dimension(125, 57));
        n10.setPreferredSize(new java.awt.Dimension(100, 75));
        n10.setRequestFocusEnabled(false);
        n10.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                n10ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(valor, javax.swing.GroupLayout.PREFERRED_SIZE, 418, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(n1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(maisemenos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addComponent(n7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(n4, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(apagartudo, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(n8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(n9, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(apagartudo1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(apagartudo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(soma, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(subtracao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(n2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(n3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(n5, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(n6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addComponent(n0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(n10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(igual, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(divisao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(multiplicacao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                    .addComponent(texto, javax.swing.GroupLayout.PREFERRED_SIZE, 418, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(16, Short.MAX_VALUE))
        );

        jPanel1Layout.linkSize(javax.swing.SwingConstants.HORIZONTAL, new java.awt.Component[] {divisao, maisemenos, multiplicacao, n1, n2, n3, n4, n5, n6, n7, n8, n9, soma, subtracao});

        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(valor, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(texto, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(apagartudo1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(apagartudo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(apagartudo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(soma, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(n9, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(subtracao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(n5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(divisao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(n1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(multiplicacao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(maisemenos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n0, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(igual, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(n10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(16, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(32, Short.MAX_VALUE))
        );

        setSize(new java.awt.Dimension(456, 588));
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents
    
    private void cliqueIgual(){
        botaoIgual=true;
        if(operacao==true){
            operacao=false;
        }
        calculo();
    }
    
    private void numeros(int a) {
        try {
            if(botaoIgual==true){
               limparCampos();
            }
            String textoAtual = texto.getText();
            if (textoAtual.equals("0") || textoAtual.equals("") ||continuar==true) {
                texto.setText(String.valueOf(a));
            } else {
                texto.setText(textoAtual + a);
            }
            continuar=false;
            operacao=false;
        } catch (NumberFormatException e) {
            texto.setText(String.valueOf(a));
            ponto=false;
        }
    }

    private double conta(double a, double b, String c){
                if (c=="+"){
                        return a+b;
                }else if(c=="-"){
                        return a-b;      
                }else if(c=="/"){
                        if (b != 0) {
                            return a/b;
                        } else {
                            JOptionPane.showMessageDialog(null, "Impossivel dividir qualquer número por 0","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                            limparCampos();
                        }      
                }else if(c=="*"){
                        return a*b;    
                }
                return 0; 
    }

    private void limparCampos(){
                valor.setText (String.valueOf(""));
                texto.setText (String.valueOf("0"));
                parcial=0;
                total=0;
                textodecima="";
                textoantigo="";
                op="";
                ponto=false; 
                continuar=false;
                operacao=false;
                botaoIgual=false;
    }

    private void calculo(){
            try{
                if(op.equals("")){
                //não faz nada!
                }else{
                    
                    if (continuar==false){
                        parcial = Double.parseDouble(texto.getText());
                    }
                    if (operacao==false){

                    textodecima = valor.getText();
                    if (textodecima.equals("")){
                        textodecima=parcial+op;
                        total=parcial;
                        texto.setText (String.valueOf("0"));
                    }else{

                        if (textodecima.equals(textoantigo)){
                            textodecima +=op+parcial;
                            textoantigo=textodecima;
                        }else{
                            textodecima = total+op+parcial;
                            textoantigo=textodecima;
                        }


                        total  = conta(total,parcial,op);
                        texto.setText (String.valueOf(total));
                        continuar=true;
                        operacao=true;
                    }
                    valor.setText (String.valueOf(textodecima));
                    ponto = false;
                    }else{
                        textodecima =textoantigo+op;
                        valor.setText (String.valueOf(textodecima));
                    }
                    if(botaoIgual==true){
                    textoantigo=textodecima;
                    }
            }

            }catch (NumberFormatException e) {

            }

    }
    
    private void n1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n1ActionPerformed
        numeros(1);
    }//GEN-LAST:event_n1ActionPerformed

    private void n3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n3ActionPerformed
        numeros(3);
    }//GEN-LAST:event_n3ActionPerformed

    private void n6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n6ActionPerformed
        numeros(6);
    }//GEN-LAST:event_n6ActionPerformed

    private void n8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n8ActionPerformed
        numeros(8);
    }//GEN-LAST:event_n8ActionPerformed

    private void n7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n7ActionPerformed
        numeros(7);
    }//GEN-LAST:event_n7ActionPerformed

    private void n0ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n0ActionPerformed
        numeros(0);
    }//GEN-LAST:event_n0ActionPerformed

    private void somaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_somaActionPerformed
        botaoIgual=false;
        op="+";
        calculo();
    }//GEN-LAST:event_somaActionPerformed

    private void multiplicacaoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_multiplicacaoActionPerformed
        botaoIgual=false;
        op="*";
        calculo();     
    }//GEN-LAST:event_multiplicacaoActionPerformed

    private void igualActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_igualActionPerformed
        cliqueIgual();
    }//GEN-LAST:event_igualActionPerformed

    private void textoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_textoActionPerformed
        
    }//GEN-LAST:event_textoActionPerformed

    private void n2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n2ActionPerformed
        numeros(2);
    }//GEN-LAST:event_n2ActionPerformed

    private void n4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n4ActionPerformed
        numeros(4);
    }//GEN-LAST:event_n4ActionPerformed

    private void n5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n5ActionPerformed
        numeros(5);
    }//GEN-LAST:event_n5ActionPerformed

    private void n9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n9ActionPerformed
        numeros(9);
    }//GEN-LAST:event_n9ActionPerformed

    private void subtracaoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_subtracaoActionPerformed
        botaoIgual=false;
        op="-";
        calculo();        
    }//GEN-LAST:event_subtracaoActionPerformed

    private void divisaoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_divisaoActionPerformed
        botaoIgual=false;
        op="/";
        calculo();        
    }//GEN-LAST:event_divisaoActionPerformed

    private void textoMouseMoved(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_textoMouseMoved
        
    }//GEN-LAST:event_textoMouseMoved

    private void maisemenosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_maisemenosActionPerformed
        try{
            
            if (texto.getText().equals("")){
                valor.setText (String.valueOf(""));
                texto.setText (String.valueOf("0"));
                limparCampos();
            }      
            
            if (texto.getText().equals("-")){
                texto.setText (String.valueOf("0"));
            }else{
                parcial  = Double.parseDouble(texto.getText());
                if (parcial==0){
                    texto.setText (String.valueOf("-"));
                }else{
                parcial    =  parcial*-1;
                texto.setText (String.valueOf(parcial));
            }
            }
        }catch (NumberFormatException e){
           texto.setText (String.valueOf("0"));
           limparCampos();
        }
    }//GEN-LAST:event_maisemenosActionPerformed

    private void apagartudoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_apagartudoActionPerformed
        limparCampos();
    }//GEN-LAST:event_apagartudoActionPerformed

    private void apagartudo1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_apagartudo1ActionPerformed
        texto.setText (String.valueOf("0"));
    }//GEN-LAST:event_apagartudo1ActionPerformed

    private void apagartudo2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_apagartudo2ActionPerformed
        String textoAtual = texto.getText();
        if (!textoAtual.isEmpty()) {
            if (textoAtual.length() > 1) {
                String novoTexto = textoAtual.substring(0, textoAtual.length() - 1);
                texto.setText(novoTexto);
            }else {
                texto.setText("0");
            }   
        }
    }//GEN-LAST:event_apagartudo2ActionPerformed

    private void textoKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textoKeyReleased
    
    }//GEN-LAST:event_textoKeyReleased

    private void textoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textoKeyTyped
        if (evt.getKeyChar() == KeyEvent.VK_DELETE){
            texto.setText("0");
        }else{
            
            
            String textoAtual = texto.getText();
            if (!textoAtual.contains(".")) {
                ponto=false;
            }else{
                ponto=true;
            }

            if (textoAtual.equals("0") || textoAtual.equals("") || continuar==true) {
                texto.setText(String.valueOf(""));
            }else{
                texto.setText(String.valueOf(textoAtual));

            }
            
            String caracteres="";
            if(ponto==false){
                caracteres="0987654321.";
                if (evt.getKeyChar() == KeyEvent.VK_PERIOD) {
                ponto=true;
                }
            }else{
                caracteres="0987654321";
            }
            if(!caracteres.contains(evt.getKeyChar()+"")){
                evt.consume();
                texto.setText(String.valueOf(textoAtual));
            }else{
                continuar=false;
                operacao=false;
            }
            if (evt.getKeyChar() == KeyEvent.VK_BACK_SPACE ){
                if (textoAtual.length() < 1) {
                    texto.setText("0");
                }
            }else if (evt.getKeyChar() == '+') {
                botaoIgual=false;
                op="+";
                calculo();
            }else if (evt.getKeyChar() == '-') {
                botaoIgual=false;
                op="-";
                calculo();
            }else if (evt.getKeyChar() == '/') {
                botaoIgual=false;
                op="/";
                calculo();
            }else if (evt.getKeyChar() == '*') {
                botaoIgual=false;
                op="*";
                calculo();
            }else if (evt.getKeyChar() == KeyEvent.VK_ENTER) {
                cliqueIgual();
            }else if(!caracteres.contains(evt.getKeyChar()+"")){
                evt.consume();
                texto.setText(String.valueOf(textoAtual));
                if(botaoIgual==true){
                    limparCampos();
                    texto.setText(String.valueOf("0"));
                }
            }else{
                if(botaoIgual==true){
                    limparCampos();
                    texto.setText(String.valueOf(""));
                }
            }
        }
        
    }//GEN-LAST:event_textoKeyTyped

    private void n10ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_n10ActionPerformed
        String textoAtual = texto.getText();
        if (ponto==false){
            try {
                if (!textoAtual.contains(".")) {
                    texto.setText(textoAtual + ".");
                    ponto=true;
                }
            } catch (Exception e) {
                texto.setText(textoAtual);
                ponto=false;
            }
        }
    }//GEN-LAST:event_n10ActionPerformed

    private void valorActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_valorActionPerformed
        
    }//GEN-LAST:event_valorActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Tela.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Tela.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Tela.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Tela.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Tela().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton apagartudo;
    private javax.swing.JButton apagartudo1;
    private javax.swing.JButton apagartudo2;
    private javax.swing.JButton divisao;
    private javax.swing.JButton igual;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JButton maisemenos;
    private javax.swing.JButton multiplicacao;
    private javax.swing.JButton n0;
    private javax.swing.JButton n1;
    private javax.swing.JButton n10;
    private javax.swing.JButton n2;
    private javax.swing.JButton n3;
    private javax.swing.JButton n4;
    private javax.swing.JButton n5;
    private javax.swing.JButton n6;
    private javax.swing.JButton n7;
    private javax.swing.JButton n8;
    private javax.swing.JButton n9;
    private javax.swing.JButton soma;
    private javax.swing.JButton subtracao;
    private javax.swing.JTextField texto;
    private javax.swing.JTextField valor;
    // End of variables declaration//GEN-END:variables
}
