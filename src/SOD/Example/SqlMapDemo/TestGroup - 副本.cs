//ʹ�øó���ǰ�������ó��򼯣�PWMIS.Core���������涨������ƿռ�ǰ׺��Ҫʹ�ãУףͣɣӣ�������Ϣ����鿴 http://www.pwmis.com/sqlmap 
// ========================================================================
// Copyright(c) 2008-2010 ��˾����, All Rights Reserved.
// ========================================================================
using System;
using System.Data;
using System.Collections.Generic;
using PWMIS.DataMap.SqlMap;
using PWMIS.DataMap.Entity;
using PWMIS.Common;

namespace TestWebAppDAL.SqlMapDAL
{
/// <summary>
/// �ļ�����TestSqlMapClass.cs
/// �ࡡ����TestSqlMapClass
/// �桡����1.0
/// ����ʱ�䣺2018/12/9 10:17:46
/// ��;������SQL-MAPʾ�����Գ���
/// ������Ϣ�����ļ��� PDF.NET Code Maker �Զ����ɣ��޸�ǰ���ȱ��ݣ�
/// </summary>
public partial class TestSqlMapClass
    : DBMapper 
{
	/// <summary>
	/// Ĭ�Ϲ��캯��
	/// </summary>
    public TestSqlMapClass()
    {
        Mapper.CommandClassName = "TestGroup";
        //CurrentDataBase.DataBaseType=DataBase.enumDataBaseType.SqlServer;
        Mapper.EmbedAssemblySource="SqlMapDemo,SqlMapDemo.SqlMap.config";//SQL-MAP�ļ�Ƕ��ĳ������ƺ���Դ���ƣ�����ж��SQL-MAP�ļ������ڴ�ָ����
    }


    /// <summary>
    /// �ҳ�ÿһ��ϵ����߷֣����Ұ�ϵ��ţ�ѧ�������������
    /// </summary>
    /// <returns></returns>
    public DataSet QueryStudentSores( ) 
    { 
            //��ȡ������Ϣ
            CommandInfo cmdInfo=Mapper.GetCommandInfo("QueryStudentSores");
            //ִ�в�ѯ
            return CurrentDataBase.ExecuteDataSet(CurrentDataBase.ConnectionString, cmdInfo.CommandType, cmdInfo.CommandText ,null);
        //
    }//End Function

    /// <summary>
    /// ��ѯ����ϵ��ѧ����Ϣ
    /// </summary>
    /// <param name="DID"></param>
    /// <returns></returns>
    public DataSet GetStudent(Int32 DID   ) 
    { 
            //��ȡ������Ϣ
            CommandInfo cmdInfo=Mapper.GetCommandInfo("GetStudent");
            //������ֵ���Ƽ�ʹ�ø��ַ�ʽ��
            cmdInfo.DataParameters[0].Value = DID;
            //������ֵ��ʹ��������ʽ��
            //cmdInfo.SetParameterValue("@DID", DID);
            //ִ�в�ѯ
            return CurrentDataBase.ExecuteDataSet(CurrentDataBase.ConnectionString, cmdInfo.CommandType, cmdInfo.CommandText , cmdInfo.DataParameters);
        //
    }//End Function

    /// <summary>
    /// ��ѯ����ϵ��ѧ���ɼ�
    /// </summary>
    /// <param name="Category"></param>
    /// <returns></returns>
    public DataSet GetStudentScore(String Category   ) 
    { 
            //��ȡ������Ϣ
            CommandInfo cmdInfo=Mapper.GetCommandInfo("GetStudentScore");
            //������ֵ���Ƽ�ʹ�ø��ַ�ʽ��
            cmdInfo.DataParameters[0].Value = Category;
            //������ֵ��ʹ��������ʽ��
            //cmdInfo.SetParameterValue("@Category", Category);
            //ִ�в�ѯ
            return CurrentDataBase.ExecuteDataSet(CurrentDataBase.ConnectionString, cmdInfo.CommandType, cmdInfo.CommandText , cmdInfo.DataParameters);
        //
    }//End Function

    /// <summary>
    /// ��ѯѧ���ĳɼ�
    /// </summary>
    /// <param name="StuId"></param>
    /// <returns></returns>
    public List<SqlMapDemo.StudentScore> GetStudentScore(Int32 StuId   ) 
    { 
            //��ȡ������Ϣ
            CommandInfo cmdInfo=Mapper.GetCommandInfo("GetStudentScore");
            //������ֵ���Ƽ�ʹ�ø��ַ�ʽ��
            cmdInfo.DataParameters[0].Value = StuId;
            //������ֵ��ʹ��������ʽ��
            //cmdInfo.SetParameterValue("@StuId", StuId);
            //ִ�в�ѯ
            

            return PWMIS.DataProvider.Data.AdoHelper.QueryList<SqlMapDemo.StudentScore>(CurrentDataBase.ExecuteReader(CurrentDataBase.ConnectionString, cmdInfo.CommandType, cmdInfo.CommandText, cmdInfo.DataParameters));
        //
    }//End Function


}//End Class

}//End NameSpace 
