﻿using ConexaoCaninaApp.Application.Dto;
using ConexaoCaninaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoCaninaApp.Application.Interfaces
{
	public interface ICaoService
	{
		Task<Cao> AdicionarCao(CaoDto caoDto);
		Task AprovarCao(int caoId);
		Task<Cao> ObterPorId(int id);
		Task AtualizarCao(EditarCaoDto editarCaoDto);
		Task PublicarCao(int id);
		Task<bool> VerificarPerimissaoEdicao(int caoId, int usuarioId);
		Task ExcluirCao(int id);
	}
}
