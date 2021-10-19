# abp-add-module-bug

To reproduce the problem use the following command.

Create a module project

```bash
abp new MainApp -t module
```

Now add the module

```bash
abp add-module MainApp.ModuleOne --new --add-to-solution-file
```

Now open the solution.
