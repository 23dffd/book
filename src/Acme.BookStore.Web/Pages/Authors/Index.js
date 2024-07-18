$(function () {
    // 获取本地化资源
    var l = abp.localization.getResource('BookStore');
    // 创建新建作者模态框管理器
    var createModal = new abp.ModalManager(abp.appPath + 'Authors/CreateModal');
    // 创建编辑作者模态框管理器
    var editModal = new abp.ModalManager(abp.appPath + 'Authors/EditModal');

    // 初始化作者数据表
    var dataTable = $('#AuthorsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.bookStore.authors.author.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible:
                                        abp.auth.isGranted('BookStore.Authors.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible:
                                        abp.auth.isGranted('BookStore.Authors.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'AuthorDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        acme.bookStore.authors.author
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('BirthDate'),
                    data: "birthDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                }
            ]
        })
    );

    // 新建作者模态框关闭后刷新数据表
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    // 编辑作者模态框关闭后刷新数据表
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    // 点击新建作者按钮时打开新建作者模态框
    $('#NewAuthorButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});