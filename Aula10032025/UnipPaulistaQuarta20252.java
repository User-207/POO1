/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package unippaulistaquarta20252;

import javax.swing.JOptionPane;
import unippaulistaquarta20252.model.dado.Funcionario;
import unippaulistaquarta20252.model.dado.Pessoa;
import unippaulistaquarta20252.model.dado.PessoaFisica;

/**
 *
 * @author UNIP
 */
public class UnipPaulistaQuarta20252 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        int id = Integer.parseInt(JOptionPane.showInputDialog("ID"));
        String funcional = JOptionPane.showInputDialog("Funcional");
        String cpf = JOptionPane.showInputDialog("cpf");
        String nome = JOptionPane.showInputDialog("nome");
        Pessoa p = new Pessoa(id,nome);
        Pessoa pf = new PessoaFisica(cpf,id,nome);
        Pessoa fu = new Funcionario(funcional,cpf,id,nome);
        JOptionPane.showInputDialog(null,p);
        JOptionPane.showInputDialog(null,pf);
        JOptionPane.showInputDialog(null,fu);
        
        System.out.println(p);
        System.out.println(pf);
        System.out.println(fu);
    }
    
}
